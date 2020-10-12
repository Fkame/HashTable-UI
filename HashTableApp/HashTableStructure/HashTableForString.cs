﻿using System;
using HashTableApp.HashTableStructure.HashFunctions;
using HashTableApp.HashTableStructure.ReHashFunctions;

namespace HashTableApp.HashTableStructure
{
    /// <summary>
    /// Структура хэш-таблицы для хранения строк. Не предусматривает самостоятельный ввод хэша, 
    /// а вычисляет самостоятельно на основе выбранной хэш-функции.
    /// </summary>
    public class HashTableForString
    {
        /// <summary>
        /// Динамический аспект, представляет собой хэш-функцию, которая будет использоваться.
        /// </summary>
        public IHashFunction HashFunc { get; }

        /// <summary>
        /// Динамический аспект, представляет собой рехэш-функцию, которая будет использоваться.
        /// </summary>
        public IRehashFunction ReHashFunc { get; }

        /// <summary>
        /// 
        /// </summary>
        private string[] values;

        /// <summary>
        /// Количество элементов в массиве в текущий момент.
        /// </summary>
        private int size;

        /// <summary>
        /// Количество элементов в массиве в текущий момент.
        /// </summary>
        public int HashMapSize { get; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public HashTableForString(IHashFunction f1, IRehashFunction f2)
        {
            HashFunc = f1;
            ReHashFunc = f2;
            this.size = 0;
            int maxArraySize = HashFunc.GetMaxValue();
            this.values = new string[maxArraySize];
        }

        /// <summary>
        /// Метод добавляет значение в коллекцию. Если хэш-таблица заполнена - вернёт -1.
        /// Если возникает коллизия - метод будет производить рехэширование до тех пор, пока не найдёт место.
        /// </summary>
        /// <param name="word">Значение, которое нужно добавить в коллекцию</param>
        /// <returns>Возвращает индекс, под которым хранится слово помещено слово.</returns>
        public int Add(string word)
        {
            if (this.size == this.values.Length) 
                return -1;

            if (this.IsExists(word)) return -1;

            int index = HashFunc.CreateHash(word);
            int lvlOfRehash = 1;
            while (values[index] != null)
            {
                index = ReHashFunc.Rehash(index, lvlOfRehash);
                lvlOfRehash++;
            }
            values[index] = word;

            this.size++;
            return index;
        }

        /// <summary>
        /// Удаляет значение из хэш-таблицы
        /// </summary>
        /// <param name="word">Значение, которое нужно удалить.</param>
        /// <returns>Хэш, по которому хранилось значение.</returns>
        public int Remove(string word)
        {
            if (this.IsEmpty()) return -1;
            if (!this.IsExists(word)) return -1;

            int index = HashFunc.CreateHash(word);
            int lvlOfRehash = 1;
            while (values[index] != word)
            {
                index = ReHashFunc.Rehash(index, lvlOfRehash);
                lvlOfRehash++;
            }
            values[index] = null;

            this.size--;
            return index;

        }

        /// <summary>
        /// Возвращает хэш слова с учётом его рехэширования.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public int GetHash(string word, bool isRehashIncude)
        {
            int index = HashFunc.CreateHash(word);
            if (values[index] == null) return -1;
            if (!isRehashIncude) return index;

            int lvlOfRehash = 1;
            while (values[index] != word)
            {
                index = ReHashFunc.Rehash(index, lvlOfRehash);
                lvlOfRehash++;
            }
            return index;
        }

        /// <summary>
        /// Метод проверяет, существует ли такой объект уже в хэш-таблице.
        /// </summary>
        /// <param name="word">Слово, наличие которого в хэш-таблице необходимо проверить.</param>
        /// <returns>Существует ли элемент в хэш-таблице.</returns>
        public bool IsExists(string word)
        {
            int index = HashFunc.CreateHash(word);
            if (values[index] == null) return false;

            if (values[index] == word) return true;

            int startIndex = index;
            int lvlOfRehash = 1;
            while (values[index] != null & index != startIndex) 
            {
                if (values[index] == word) 
                    return true;
                index = ReHashFunc.Rehash(index, lvlOfRehash);
                lvlOfRehash = (lvlOfRehash + 1) % HashFunc.GetMaxValue();
            }

            return false;
        }

        /// <summary>
        /// Метод проверяет, пуста ли хэш-таблица.
        /// </summary>
        /// <returns>Пуста ли хэш-таблица?</returns>
        public bool IsEmpty()
        {
            return this.size == 0;
        }

        /// <summary>
        /// Проверяет, заполнена ли хэш-таблица.
        /// </summary>
        /// <returns>Заполнена ли хэш-таблица?</returns>
        public bool IsFull()
        {
            return this.size == this.values.Length;
        }

        /// <summary>
        /// Выгрузка хэш-таблицы
        /// </summary>
        /// <returns></returns>
        public string[] GetFullHashTableAsArray()
        {
            string[] copy = new string[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                copy[i] = values[i];
            }
            return copy;
        }

        /// <summary>
        /// Выгрузка хэш-таблицы
        /// </summary>
        /// <returns></returns>
        public string[] GetOnlyNotNullValues()
        {
            string[] partCopy = new string[this.size];
            int j = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] != null) partCopy[j++] = values[i];
            }

            return partCopy;
        }

        /// <summary>
        /// Метод очищает хэш-таблицу
        /// </summary>
        public void Clear()
        {
            Array.Clear(values, 0, values.Length);
            this.size = 0;
        }

        public int LevelOfRehash(string value)
        {
            // Если значения не существует - выход из метода
            if (!IsExists(value)) return -1;

            // Если значение не было решэшировано - выход из метода
            int index = HashFunc.CreateHash(value);
            if (values[index].Equals(value)) return 0;

            int startIndex = index;
            int lvlOfRehash = 1;

            // Мы ведь уверены, что оно есть (благодаря вызову IsExists()), значит можно не волноваться о бесконечном цикле
            while (true)
            {
                if (values[index] == value) 
                    return lvlOfRehash;

                index = ReHashFunc.Rehash(index, lvlOfRehash);
                lvlOfRehash = (lvlOfRehash + 1) % HashFunc.GetMaxValue();
            }
        }
    }
}
