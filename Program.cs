﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyOwnList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AList<int> list = new AList<int>();
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
            //Console.WriteLine("The size is " + list.Size());
            list.AddElement(4);
            list.AddElement(5);
            list.AddElement(6);
            list.print();
            Console.WriteLine( );
            list[1] = 0;
            list[2] = 0;
            list[3] = 1;
            list[4] = 1;
            list[5] = 1;
            list[6] = 0;
            list[7] = 1;
            list.print();

            Console.WriteLine(list[1]);
            //Console.WriteLine("The size is " + list.Size());
           // AList<int> rev=list.reverseElements();
          // rev.print();

            //foreach(int x in rev)
            //{
            //    Console.WriteLine(  x);
            //}

            //Console.WriteLine("the element"+ list.GetElementAt(0)); 
            Console.ReadKey();


        }
    }
}
