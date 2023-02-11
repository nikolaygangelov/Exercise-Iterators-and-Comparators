using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        List<T> customList;

        public CustomStack()
        {
            customList = new List<T>();
        }

        public void Push(T element)
        {
            customList.Add(element);
        }

        public void Pop()
        {
            if (customList.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            else
            {
                customList.RemoveAt(customList.Count - 1);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = customList.Count - 1; i >= 0; i--)
            {
                yield return customList[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
