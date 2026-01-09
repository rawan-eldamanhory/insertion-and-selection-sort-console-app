using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Array
    {
        private int[] _items;
        private int _size;
        private int _length;

        public int Size => _size;
        public int Length => _length;

        public Array(int size)
        {
            _size = size;
            _length = 0;
            _items = new int[size];
        }

        //fill the array
        void Fill()
        {
            int no_of_items;
            Console.WriteLine("How many items you want to fill ? ");
            no_of_items = int.Parse(Console.ReadLine());
            if (no_of_items > _size)
            {
                Console.WriteLine("You cannot exceed the array size");
                return;
            }
            else
            {
                for (int i = 0; i < no_of_items; i++)
                {
                    Console.WriteLine("Enter item " + i);
                    _items[i] = int.Parse(Console.ReadLine());
                    _length++;
                }
            }
        }

        //traverse
        void Display()
        {
            for (int i = 0; i < _length; i++)
                Console.WriteLine(_items[i]);
        }

        //insertion sort
        public void InsertionSort()
        {
            for (int i = 1; i < _length; i++)
            {
                int key = _items[i];
                int j = i - 1;

                while (j >= 0 && _items[j] > key)
                {
                    _items[j + 1] = _items[j];
                    j--;
                }

                _items[j + 1] = key;
            }
        }

        //selection sort
        public void SelectionSort()
        {
            for (int i = 0; i < _length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < _length; j++)
                {
                    if (_items[j] < _items[minIndex])
                        minIndex = j;
                }

                int temp = _items[minIndex];
                _items[minIndex] = _items[i];
                _items[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            int arraysize;
            Console.WriteLine("Enter the Array size : ");
            arraysize = int.Parse(Console.ReadLine());
            Array arr = new Array(arraysize);
            arr.Fill();
            Console.WriteLine("Array content before sorting : ");
            arr.Display();
            arr.InsertionSort();
            Console.WriteLine("Array content after insertion sorting : ");
            arr.Display();
            arr.SelectionSort();
            Console.WriteLine("Array content after selection sorting : ");
            arr.Display();

            Console.ReadKey();
        }
    }
}
