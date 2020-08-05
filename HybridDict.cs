using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

namespace LISTDICTASS
{
    class HybridDict
    {
        static void Main()
        {
            HybridDictionary hd = new HybridDictionary();
            hd.Add("hello", "sravani");
            hd.Add("gud", "mrng");
            hd.Add("wel", "come");
            hd.Add("nyc", "day");
            hd.Add("wonder", "ful");
            foreach(DictionaryEntry d in hd)
            {
                Console.WriteLine(d.Key +"-----"+d.Value);
            }
            Console.WriteLine("-------------using ENUMERATor------------------");
            IDictionaryEnumerator id = hd.GetEnumerator();
            while (id.MoveNext())
            {
                Console.WriteLine("{0}----->{1}",id.Key,id.Value);
            }
            Console.WriteLine("-----------------------using count property--------------");
            Console.WriteLine("count is: {0}", hd.Count);
            Console.WriteLine("Is synchrozied or not :{0}", hd.IsSynchronized);
            Console.WriteLine("is list is fixed size:{0}", hd.IsFixedSize);
            Console.WriteLine("list is readonly property ?:{0}", hd.IsReadOnly);
            Console.WriteLine("-----------------get an icollection contain keys------------");
            ICollection ic = hd.Keys;
            foreach (var s in ic)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-----------------get an icollection contain values------------");
            ICollection ic1 = hd.Values;
            foreach (var s in ic1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------------two hydrid Dict are equal or not------------");
            HybridDictionary hd1 = new HybridDictionary();
            hd1.Add("hello", "sri");
            hd1.Add("gud", "m");
            hd1.Add("wel", "come");
            hd1.Add("nyc", "day");
            hd1.Add("wonder", "ful");
            Console.WriteLine(hd.Equals(hd1));
        }
    }
}
