using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_UI_Prototype.SubForms
{
    /// <summary>
    /// Интерфейс, реализация которого заключает контракт о том, 
    /// что форма содержит некоторое описание к самой себе в виде строки.
    /// </summary>
    public interface IFormWithHint
    {
        string GetHintText();
    }
}
