using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MyList<T> // istediğimizi yazabiliriz ama T = Type'dan gelir.
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item) // parametre olarak istediğimiz veri tipi ile çalışabilir
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public void View()
        {
            foreach (T arrayItems in _array)
            {
                Console.WriteLine(arrayItems);
            }
        }
        private int _count;

        public int MyCount
        {
            get { return _array.Length; }  // dizinin uzunluğunu yolla sadece get edebil yani readonly
        }

    }
}
