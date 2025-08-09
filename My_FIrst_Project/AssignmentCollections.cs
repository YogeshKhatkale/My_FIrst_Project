using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal class AssignmentCollections
    {
        static void Main()
        {
            // Generic Collections

            // 1 create a Hashset add 5 elements ,perform insert,remove,union with, intersection

            HashSet<int> set1 = new HashSet<int>() { 1, 5, 2, 3, 8, 77 };
            HashSet<int> set2 = new HashSet<int>() { 1, 44, 5, 3, 8, 15, 12, 14 };


            set1.Add(4);

            set2.Remove(8);

            set1.UnionWith(set2);
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }
            

            set2.IntersectWith(set1);
            foreach (var item in set2)
            {
                Console.WriteLine("\n"+ item);
            }

            // 2 Create a list add 5 elements perform Add,remove and clear
            
            List<int> Mylist = new List<int>();
            Mylist.Add(4);
            Mylist.Add(5);
            Mylist.Add(77);
            Mylist.Add(84);
            Mylist.Add(2);
            Mylist.Remove(84);
            Mylist.Clear();


            // Non- Generic Collections

            //    ArrayList

            ArrayList arrayList = new ArrayList();

            for(int i =2; i<12; i++)
            {
                arrayList.Add(i);
            }
            Console.WriteLine("Original ArrayList :\n");
            foreach (var value in arrayList)
            {
                Console.WriteLine(value);
            }

            arrayList.Remove(10);

            arrayList.RemoveAt(5);
            Console.WriteLine("Original ArrayList after removal :\n");

            foreach (int value in arrayList)
            {
                Console.WriteLine(value);

            }

            // hashtable

            Hashtable ht = new Hashtable();
            ht.Add("id",19);
            ht.Add("Name","Messi");
            ht.Add("age",30);
            ht.Add("city","pune");
            ht.Add("game","Langdi");
            ht.Add("Height",5.9);

            foreach(DictionaryEntry dicthash in ht)
            {
                Console.WriteLine(dicthash.Key + " : " + dicthash.Value);
            }
        



        }
    }
}
