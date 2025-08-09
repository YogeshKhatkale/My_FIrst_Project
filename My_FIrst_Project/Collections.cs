using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal interface Collections
    {
        static void Main()
        {
            // Generic collections
            //1> List 

            //List declaration

            List<int> numbers = new List<int>();
            numbers.Add(11);
            numbers.Add(12);
            numbers.Add(13);
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers[2]);


            // 2> Dictionary

            // Initilization of dictionary

            Dictionary<string, int> dict = new Dictionary<string, int>();

            // Add key- value pairs  in dictionary

            dict.Add("Rohit", 45);
            dict.Add("Virat", 18);
            dict.Add("Raina", 03);

            Console.WriteLine("All elements added in the dictionary. ");
            foreach (KeyValuePair<string, int> pair in dict)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            // Modify Dictionary

            dict["Virat"] = 19; // giving same value when 0 is assigned at first?? 
            Console.WriteLine("All elements added in the dictionary after modifying. ");
            foreach (KeyValuePair<string, int> pair in dict)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            // Search element in dictionary
            if (dict.ContainsKey("Rohit"))
            {
                Console.WriteLine("Exists");
            }


            // 3> Queue
            // FIFO - first in first out

            Queue qu = new Queue();
            qu.Enqueue("test");
            qu.Enqueue(11);
            qu.Enqueue(true);

            // remove the elements from queue

            object fisrtEl = qu.Dequeue();
            object secondEl = qu.Dequeue();

            // Display remlved elements
            Console.WriteLine($"{fisrtEl} and {secondEl} are removed from Queue.");


            // 4> stack
            // LIFO 

            Stack st = new Stack();
            st.Push("orety");
            st.Push(42);
            Console.WriteLine(st);

            object topEl = st.Pop();
            object swcondEl = st.Pop();
            Console.WriteLine(topEl);


            // 5> Hashset

            HashSet<int> num = new HashSet<int>();

            // adding elements in the hashset

            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(4);
            num.Add(5);
            num.Add(5); // Duplicate Elements

            Console.WriteLine("Hashset Elements");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

            // Find element in hashset

            bool Containstwo = num.Contains(2);
            Console.WriteLine("Hashset element 2 :" + Containstwo);



            // Non-Generic Collections
            // 1> ArrayList

            // Creating Arraylist
            ArrayList arr = new ArrayList();

            // Adding elements
            arr.Add(1);
            arr.Add("eryjhgf");
            arr.Add(true);

            // insert element at specific index 
            arr.Insert(2, "reth");

            //  display all elements
            foreach (var itm in arr)
            {
                Console.WriteLine(itm);
            }

            // removing using item

            arr.Remove("reth");

            Console.WriteLine("\n after removal. :");
            foreach (var tt in arr)
            {
                Console.WriteLine(tt);
            }

            // removing using index

            arr.RemoveAt(2);
            foreach (var ttt in arr)
            {
                Console.WriteLine("\n\n" + ttt);
            }


            // 2> Hastable

            // create hashtble
            Hashtable hash = new Hashtable();
            hash.Add(5, "ueghkuhg");
            hash.Add(2, "Virat");
            hash.Add(4, "Rhitt");

            Console.WriteLine("value for key 2 : " + hash[2]);
            if (hash.ContainsKey(2))
            {
                Console.WriteLine("key 2 is there.");

            }

            // remove a key
            hash.Remove(4);

            foreach(DictionaryEntry dict2 in hash)
            {
                Console.WriteLine($"\nkey : {dict2.Key} , value : {dict2.Value}");   

            }


            // 3>stack
            //4>queue
        }
    }
}
