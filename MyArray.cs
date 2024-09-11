using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class MyArray
    {
        private int[] elem;
        public MyArray(int[] elements)
        {
            elem = elements;
        }
        public void Show()
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < elem.Length; i++)
            {
                Console.Write(elem[i] + " ");
            }
            Console.WriteLine();
        }
        public void Show(string info)
        {
            Show();
            Console.WriteLine($"Info: {info}\n");
        }
        public void SetElement(int index, int value)
        {
            if (index >= 0 && index < elem.Length)
            {
                elem[index] = value;
            }
        }
        public int GetElement(int index)
        {
            if (index >= 0 && index < elem.Length)
            {
                return elem[index];
            }
            else
            {
                return 0;
            }
        }
        public int GetSize()
        {
            return elem.Length;
        }
        public void Max()
        {
            int max = elem[0];
            for (int i = 1; i < elem.Length; i++)
            {
                if (elem[i] > max)
                    max = elem[i];
            }
            Console.WriteLine(max);
        }
        public void Min()
        {
            int min = elem[0];
            for (int i = 1; i < elem.Length; i++)
            {
                if (elem[i] < min)
                    min = elem[i];
            }
            Console.WriteLine(min);
        }
        public float Avg()
        {
            int sum = 0;
            for (int i = 0; i < elem.Length; i++)
            {
                sum += elem[i];
            }
            return (float)sum / elem.Length;
        }
        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < elem.Length; i++)
            {
                if (elem[i] == valueToSearch)
                    return true;
            }
            return false;
        }
        public void SortAsc()
        {
            for (int i = 0; i < elem.Length - 1; i++)
            {
                for (int j = 0; j < elem.Length - i - 1; j++)
                {
                    if (elem[j] > elem[j + 1])
                    {
                        int temp = elem[j];
                        elem[j] = elem[j + 1];
                        elem[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
        }

        public void SortDesc()
        {
            for (int i = 0; i < elem.Length - 1; i++)
            {
                for (int j = 0; j < elem.Length - i - 1; j++)
                {
                    if (elem[j] < elem[j + 1])
                    {
                        int temp = elem[j];
                        elem[j] = elem[j + 1];
                        elem[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
}
