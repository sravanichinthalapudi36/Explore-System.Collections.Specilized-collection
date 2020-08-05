using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTDICTASS
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary ld = new ListDictionary();
            ld.Add("sravani","pdrl");
            ld.Add("balu", "guntur");
            ld.Add("Appu", "Mum");
            ld.Add("Phanii", "pune");
            ld.Add("reethu", "eluru");
            ld.Add("lucky", "Assam");
            foreach (DictionaryEntry item in ld)
            {
                Console.WriteLine("{0}--------->{1}",item.Key,item.Value);
            }
            Console.WriteLine("-----------------------using count property--------------");
            Console.WriteLine("count is: {0}",ld.Count);
            Console.WriteLine("Is synchrozied or not :{0}",ld.IsSynchronized);
            Console.WriteLine("is list is fixed size:{0}",ld.IsFixedSize);
            Console.WriteLine("list is readonly property ?:{0}",ld.IsReadOnly);
            Console.WriteLine("-----------------get an icollection contain keys------------");
            ICollection ic = ld.Keys;
            foreach (var s in ic)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("------------------get an Icollection contain values--------------");
            ICollection ic1 = ld.Values;
            foreach (var s in ic)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------get Enumerator--------------------------------");
            IDictionaryEnumerator en = ld.GetEnumerator();

            while (en.MoveNext())
            {
                Console.WriteLine(en.Key + " --> "+ en.Value);
            }
            Console.WriteLine("----------------Checks contains the key---------------------------");
            Console.WriteLine(ld.Contains("reethu"));
            Console.WriteLine("-------------copyTo Method----------------------------------------");
            Console.WriteLine("-----------------// with key reethu------------------------------"); 
            Console.WriteLine(ld["reethu"]);

            Console.WriteLine("----------// Setting the value associated with key balu-----------"); 
            ld["balu"] = "hey babluu";
            foreach (DictionaryEntry de in ld)
            {
                Console.WriteLine(de.Key + "-------" + de.Value);
            }
        }
    }
}