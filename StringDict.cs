using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTDICTASS
{
    class StringDict
    {
        static void Main()
        {
            StringDictionary d = new StringDictionary();
            d.Add("A", "Apple");
            d.Add("B", "Banana");
            d.Add("C", "Cat");
            d.Add("D", "Dog");
            d.Add("E", "Elephant");
            d.Add("F", "Fish");
            foreach (DictionaryEntry dic in d)
            {
                Console.WriteLine(dic.Key + " " + dic.Value);
            }

            //DictionaryEntry[] a = { new DictionaryEntry(),
            //                        new DictionaryEntry(),
            //                        new DictionaryEntry()};

            //// copying stringdictionary to 
            //// array at the specified index 
            //d.CopyTo(a, 0);

            //// displaying key and value pairs in array myarr 
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i].Key + " " + a[i].Value);
            //}
            Console.WriteLine("-----------------getting values-------------------");
            foreach (string val in d.Values)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("------------------getting Keys--------------------");
            foreach (string val in d.Keys)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("count is :{0}",d.Count);
            Console.WriteLine("is synchronzed:{0}",d.SyncRoot);
            IEnumerator ie = d.GetEnumerator();
            DictionaryEntry de;
            while (ie.MoveNext())
            {
                de= (DictionaryEntry)ie.Current;
                Console.WriteLine(de.Key + " ----->" + de.Value);
            }
        }
    }
}