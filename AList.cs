using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnList
{
    public class AList<T>
    {
        T[] arr;
        int currentIndex;

        public AList()
        {
            arr = new T[10];
            currentIndex = -1;
        }

        // Add new element to the list
        public void AddElement(T element)
        {
            if (++currentIndex < arr.Length - 1)
            {
                //++currentIndex;
                arr[currentIndex] = element;
            }
            else
            {
                Extended();//extend the array when reach the max size
            }
        }
        //return the elemet on some index
        public T GetElementAt(int index)
        {
            if (index > -1 && index <= currentIndex)
            {
                return arr[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        //remove the elemet on some index
        public void RemoveElementAt(int index) 
        {
            if(index > -1 && index <= currentIndex)
            {
                Shift(index);//shiftting the values 
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
        public int Size()
        {
            return currentIndex + 1;
        }

        private void Shift(int index)
        {
            for (int i = index; i < currentIndex; i++) 
            {
                arr[i] = arr[i+1];
            }
            currentIndex--;
        }

        private void Extended()
        {
            T[] newArr= new T[currentIndex + 20];
            
            for(int i=0;i<=currentIndex;i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }

        public void print()
        {
            foreach(T i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
