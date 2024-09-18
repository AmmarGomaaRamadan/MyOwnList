using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            if (++currentIndex <= arr.Length-1)
            {
                
                arr[currentIndex] = element;
                //currentIndex++;
            }
            else
            {
                Extended();//extend the array when reach the max size
                AddElement(element);
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

    
        public AList<T> reverseElements()
        {
            AList<T> revList= new AList<T>();
            for(int i = currentIndex;i>=0;i--)
            {
                revList.AddElement(arr[i]);
            }
            return revList;
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
            currentIndex--;
            
            for(int i=0;i<=currentIndex ;i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }

        public void print()
        {
            for(int i=0;i<=currentIndex;i++ )
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
