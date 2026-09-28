using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodzConsole
{
    public partial class CustomList<Type>
    {
        private int _count;

        private int _capacity;


        public int Count { get { return _count; } }

        public int Capacity { get { return _capacity; } }

        public Type this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        private Type[] _array;

        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }

        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }




        public void Add(Type a)
        {
            if (_capacity == _count)
            {
                Grow();
            }
            _array[_count] = a;
            _count++;
        }

        public void Grow()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];

            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }

        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _count+elements.Count+4;
            Type[] temp = new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            int k=0;
            for(int i=_count;i<_count+elements.Count;i++)
            {
                temp[i]=elements[k];
                k++;
            }
            _array=temp;
            _count=_count+elements.Count;


        }

        public bool Contains(Type element)
        {
            foreach (Type val in _array)
            {
                if (val.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOF(Type element)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (_array[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void RemoveAt(int position)
        {
            for (int i = 0; i < _count - 1; i++)
            {
                if (i >= position)
                {
                    _array[i] = _array[i + 1];
                }
            }
            _count--;
        }

        public void Remove(Type element)
        {
            int index = IndexOF(element);

            if(index>=0)
            {
                RemoveAt(index);
            }
            
        }
    

        public void Reverse()
        {
            Type [] temp = new Type[_capacity];
            int j=0;
            for(int i=_count-1;i>=0;i--)
            {
                temp[j]=_array[i];
                j++;
            }

            _array=temp;
        }
    
    
        public bool IsGreater(Type value1,Type value2)
        {
            int value = Comparer<Type>.Default.Compare(value1,value2);

            if(value>0)
            {
                return true;
            }
            return false;
        }
    
        public void Sort()
        {
            for(int i=0;i<_count-1;i++)
            {
                for(int j=0;j<_count-1;j++)
                {
                    if(IsGreater(_array[j],_array[j+1]))
                    {
                        Type temp = _array[j+1];

                        _array[j+1]=_array[j];
                        _array[j]=temp;
                    }
                }

            }
        }
    
        public void Insert(int position,Type element)
        {
            _capacity=_count+4;
            Type[] temp = new Type[_capacity];

            for(int i=0;i<_count+1;i++)
            {
                if(i<position)
                {
                    temp[i]=_array[i];
                }
                else if(i==position)
                {
                    temp[i]=element;
                }
                else
                {
                    temp[i]=_array[i-1];
                }
            }
            _array=temp;
            _count++;
        }

        public void InsertRange(int position,CustomList<Type> elements)
        {
            _capacity = _count+elements.Count+4;
            Type[] temp = new Type[_capacity];

            for(int i=0;i<position;i++)
            {
                temp[i]=_array[i];
            }
            int j=0;
            for(int i=position;i<position+elements.Count;i++)
            {
                temp[i]=elements[j];
                j++;
            }
            int l = position+elements.Count;
            for(int i=position;i<_count;i++)
            {
                temp[l]=_array[i];
                l++;
            }
            _array=temp;
            _count=_count+elements.Count;
        }
    
        
    
    }
}