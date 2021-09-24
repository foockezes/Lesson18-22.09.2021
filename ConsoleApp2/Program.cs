using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. add element: 2. Get element by index: 3. Get all element\nyour choice: ");
            var choice = Convert.ToInt32(Console.ReadLine());
            var dictionary = new MyDictionary<int, string>();
            dictionary.AddValue(1, "Paris");
            dictionary.AddValue(2, "Oslo");
            dictionary.AddValue(3, "Lagos");
            dictionary.AddValue(4, "Melbourne");
            switch (choice)
            {
                case 1:
                    Console.Write("Add element with key.\nKey: ");
                    var k = Convert.ToInt32(Console.ReadLine());
                    Console.Write("evalue: ");
                    var v = Console.ReadLine();
                    dictionary.AddValue(k, v);
                    break;
                case 2:
                    Console.WriteLine("Get element by Index");
                    var q = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"your choice index {q}: {dictionary[q]}");
                    break;
                case 3:
                    Console.WriteLine($"Total number of elements: {dictionary.Count}\n");
                    for (int i = 0; i < dictionary.Count; i++)
                    {
                        Console.WriteLine($"{dictionary[i]}");
                    }
                    break;
            }
        }
    }
    class MyDictionary<Tkey, TValue>
    {
        private Tkey[] key;
        private TValue[] value;
        private int length;
        public MyDictionary()
        {
            key = new Tkey[0];
            value = new TValue[0];
            length = 0;
        }
        public void AddValue(Tkey tkey, TValue tvalue)
        {

            var key1 = new Tkey[length + 1];
            var value1 = new TValue[length + 1];
            for (int i = 0; i < length; i++)
            {
                key1[i] = key[i];
                value1[i] = value[i];
            }
            length++;
            key1[key1.Length - 1] = tkey;
            value1[value1.Length - 1] = tvalue;
            key = key1;
            value = value1;
        }
        public override string ToString()
        {
            string str = null;
            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    str += key[i] + " " + value[i] + "\n";
                }

            }
            else
                str += "Null\n";
            return str;
        }
        public void Clear()
        {
            key = new Tkey[0];
            value = new TValue[0];
            length = 0;
        }
        public int Count
        {
            get
            {
                return length;
            }
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index <= length)
                {
                    return key[index].ToString() + " " + value[index].ToString();
                }
                else
                {
                    return "not found";
                }
            }
        }
    }
}
