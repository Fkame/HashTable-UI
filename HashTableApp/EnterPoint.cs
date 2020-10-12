using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HashTableApp.HashTableStructure;
using HashTableApp.HashTableStructure.HashFunctions;
using HashTableApp.HashTableStructure.ReHashFunctions;

namespace HashTableApp
{
    public class EnterPoint
    {
        public static void Main(string[] args) {
            HashTableForString hashtable = new HashTableForString(
                new SimpleDivisionStringHF(500), 
                new OnMultiplicationBasedRHF(3, 500)
                );

            // Adding
            hashtable.Add("str1");
            hashtable.Add("str2");
            hashtable.Add("str3");

            // Removing 
            hashtable.Remove("str3");

            // Removing with rehash


            // GetHash


            // IsExist


            // LevelOfRehash




        }
    }
}
