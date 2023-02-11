using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class CustomListyIterator<T> : IEnumerable<List<T>>
    {
        List<T> customList;
        public CustomListyIterator(List<T> list)
        {
            customList = list;
            Index = 0;
        }

        public int Index { get; set; }
        public bool Move()
        {
            if (Index < customList.Count - 1)
            {
                Index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            return Index < customList.Count - 1;
        }

        public void Print()
        {
            if (customList.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(customList[Index]);
            }
        }
        public IEnumerator<List<T>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
