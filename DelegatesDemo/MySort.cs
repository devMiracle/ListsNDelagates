using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class MySort
    {
        public delegate int MyComparator(object o1, object o2);
        public static void IntSortAsc(List<int> _integers) {

            bool sorted = false;
            do
            {
                sorted = true;
                for (int i = 0; i < _integers.Count - 1; i++)
                {
                    if (_integers[i] - _integers[i + 1] > 0)
                    {
                        int tmp = _integers[i];
                        _integers[i] = _integers[i + 1];
                        _integers[i + 1] = tmp;
                        sorted = false;
                    }
                }
            } while (!sorted);
        }

        public static void UniversalSort(ArrayList _items, MyComparator _comparator)
        {
            bool sorted = false;
            do
            {
                sorted = true;
                for (int i = 0; i < _items.Count - 1; i++)
                {
                    if (_comparator(_items[i], _items[i + 1]) > 0)
                    {
                        object tmp = _items[i];
                        _items[i] = _items[i + 1];
                        _items[i + 1] = tmp;
                        sorted = false;
                    }
                }
            } while (!sorted);
        }

        //В проекте Sort добавить в класс Sort метод UniversalSort, который будет принимать дополнительный аргумент -
        //вторую функцию сравнения для выполнения второго этапа сортировки.Например, сортируется список товаров.
        // Первое правило сортировки передадим с указанием сравнения по ценам, второе - по названиям товаров.
        //Второй этап сортировки не должен нарушать результаты первого этапа.
        //Например, если первый этап был по ценам, то на втором этапе по названиям товаров перестановки пунктов списка допускаются только если цены текущих двух сравниваемых пунктов равны.

        public static void UniversalSortTwoArgs(ArrayList _items, MyComparator _firstComparator, MyComparator _secondComparator)
        {
            bool sorted = false;
            do
            {
                sorted = true;
                for (int i = 0; i < _items.Count - 1; i++)
                {
                    if (_firstComparator(_items[i], _items[i + 1]) > 0)
                    {
                        object tmp = _items[i];
                        _items[i] = _items[i + 1];
                        _items[i + 1] = tmp;
                        sorted = false;
                    }
                }
                for (int i = 0; i < _items.Count - 1; i++)
                {
                    if (((Good)_items[i]).Price == ((Good)_items[i + 1]).Price)
                    {
                        if (_secondComparator(_items[i], _items[i + 1]) > 0)
                        {
                            object tmp = _items[i];
                            _items[i] = _items[i + 1];
                            _items[i + 1] = tmp;
                            sorted = false;
                        }
                    }
                }
            } while (!sorted);
            
        }
        //_secondComparator(_items[i], _items[i + 1]) > 0
    }
}
