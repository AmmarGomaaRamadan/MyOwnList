﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AList<int> list= new AList<int>();
            list.AddElement(2);
            list.AddElement(3);
            list.AddElement(4);
            list.AddElement(5);
            list.AddElement(6);
            Console.WriteLine("The size is " + list.Size());
            list.AddElement(2);
            list.AddElement(3);
            list.AddElement(4);
            list.AddElement(5);
            list.AddElement(6);
            // list.RemoveElementAt(0);
            Console.WriteLine("The size is " + list.Size());
            list.AddElement(4);
            list.AddElement(5);
            list.AddElement(6);
            Console.WriteLine("The size is " + list.Size());

            //Console.WriteLine("the element"+ list.GetElementAt(0)); 
            Console.ReadKey();


        }
    }
}
