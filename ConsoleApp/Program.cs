using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. add element: 2. Get element by index: 3. Get all element\nyour choice: ");
            var choice = Convert.ToInt32(Console.ReadLine());
            MyList<string> list = new MyList<string>();
            list.AddValue("bob");
            list.AddValue("Adam");
            list.AddValue("Marley");
            switch (choice)
            {
                case 1:
                    Console.Write("Add new element: ");
                    var a = Console.ReadLine();
                    list.AddValue(a);
                    for (int i = 0; i < list.a; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.Write("Get element by index: ");
                        var b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(list[b]);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                        break;
                case 3:
                    for (int i = 0; i < list.a; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                    break;
            }

        }
        public class MyList<T>
        {
            public T[] MyAarray;
            public int a => MyAarray.Length;

            public MyList() { MyAarray = new T[0]; }
            public void AddValue(T element)
            {
                Array.Resize(ref MyAarray, MyAarray.Length + 1);
                MyAarray[MyAarray.Length - 1] = element;
            }
            public T this[int index]
            {
                get
                {
                    return MyAarray[index];
                }
                set
                {
                    MyAarray[index] = value;
                }
            }
        }
    }
}
