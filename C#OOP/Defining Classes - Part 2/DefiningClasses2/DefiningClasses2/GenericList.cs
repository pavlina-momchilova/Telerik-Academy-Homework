namespace DefiningClasses2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /*
        Problem 5. Generic class

        Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
        Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
        Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
        Check all input parameters to avoid accessing elements at invalid positions.
     */

    public class GenericList<T> where T:IComparable<T>, new()
    {
        private T[] arr;

        private int capacity;
        private int endOfList;

        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            arr = new T[Capacity];
            endOfList=0;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }

        public void Add(T element)
        {
            if (endOfList != arr.Length)
            {
                try
                {
                    arr[endOfList] = element;
                    endOfList++;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The list is Full!");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The value is invalid!");
                }
                catch (Exception)
                {
                    Console.WriteLine("You made a mistake ");
                }
            }
            else
            {
                Capacity = Capacity * 2;
                T[] newArr = new T[Capacity];
                for (int i = 0; i < endOfList; i++)
                {
                    newArr[i] = arr[i];
                }
                arr = newArr;
                arr[endOfList] = element;
                endOfList++;
            }
           
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > endOfList)
                    throw new IndexOutOfRangeException("Index out of range!");
                return this.arr[index];   
            }
            set
            {
                if (index < 0 || index > endOfList)
                    throw new IndexOutOfRangeException("Index out of range!");
                this.arr[index] = value;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > endOfList)
                throw new IndexOutOfRangeException("Index out of range!");
            if (endOfList == 0)
                throw new IndexOutOfRangeException("The list is empty!");
            T[] newArr = new T[Capacity];
            int position = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (index == i)
                {
                    position = 1;
                    continue; 
                }

                newArr[i-position] = arr[i];
            }
            endOfList--;
            arr = newArr;
        }

        public void Insert(int position, T element)
        {
            if (position < 0 || position > endOfList)
                throw new IndexOutOfRangeException("Index out of range!");
            try
            {
                if(endOfList >= Capacity)
                {
                    Capacity *= 2;
                    T[] newArr2 = new T[Capacity];
                    for(int i = 0; i < endOfList; i++)
                    {
                        newArr2[i] = arr[i];
                    }
                    arr = newArr2;
                }
                T[] newArr = new T[Capacity];
                int temp = 0;
                for (int i = 0; i < Capacity; i++)
                {
                    if (position == i)
                    {
                        newArr[i] = element;
                        temp = 1;
                        continue;
                    }
                    newArr[i] = arr[i - temp];
                }
                arr = newArr;
                endOfList++;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Not valid argument!");
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong!");
            }
           
        }

        public void Clear()
        {
            T[] newArr = new T[Capacity];
            arr=newArr;
            endOfList = 0;
        }

        public int FindingElement(T element)
        {
            bool flag = false;
            int position = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (element.Equals(arr[i]))
                {
                    flag = true;
                    position = i;
                    break;
                }
            }
            if (flag)
            {
                return position;
            }
            else
            {
                return -1;
            }
        }

        public T Min()
        {
            T min = this.arr[0];
            for (int i = 0; i < endOfList; i++)
            {
                if (min.CompareTo(arr[i])==1)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.arr[0];
            for (int i = 0; i < endOfList; i++)
            {
                if (max.CompareTo(arr[i]) == -1)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < endOfList; i++)
            {
                sb.Append(arr[i]);
                if (i != endOfList - 1)
                {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }
    }
}
