using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    {
        public int Length {get; private set;}

        private Node _root;

        public LinkedList()
        {
            Length = 0;
            _root = null;
        }

        public LinkedList(int[] array)
        {
            Length = array.Length;
            if (Length != 0)
            {
                _root = new Node(array[0]);
                Node crnt = _root;
                for (int i = 1; i < Length; i++)
                {
                    crnt.Next = new Node(array[i]);
                    crnt = crnt.Next;
                }
            }
            else
            {
                _root = null;
            }
        }

        public int this[int index]
        {
            get
            {
                CheckIndexOutOfRangeException(index);
                Node tmp = _root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp.Value;
            }
            set
            {
                CheckIndexOutOfRangeException(index);
                Node tmp = _root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Value = value;
            }
        }

        public void Add(int value)
        {
            Node crnt = _root;
            for (int i = 0; i < Length - 1; i++)
            {
                crnt = crnt.Next;
            }

            Node tmp = new Node(value);
            if (Length != 0)
            {
                crnt.Next = tmp;
            }
            else
            {

                _root = tmp;
            }
            Length++;
        }

        public void Add(int[] addArray)
        {
            Node crnt = _root;
            for (int i = 0; i < Length - 1; i++)
            {
                crnt = crnt.Next;
            }
            LinkedList linkedList = new LinkedList(addArray);
            if (Length != 0)
            {
                crnt.Next = linkedList._root;
            }
            else
            {

                _root = linkedList._root; 
            }
            
            Length += addArray.Length;
        }

        public void AddToFirst(int value)
        {
            Node tmp = new Node(value);
            tmp.Next = _root;
            _root = tmp;
            Length++;
        }

        public void AddToFirst(int[] addArray)
        {
            LinkedList linkedList = new LinkedList(addArray);
            Node crnt = linkedList._root;
            for (int i = 0; i < addArray.Length - 1; i++)
            {
                crnt = crnt.Next;
            }
            if (addArray.Length!=0) 
            {
                crnt.Next = _root;
                _root = linkedList._root;
            }
            Length += addArray.Length;
        }

        public void AddByIndex(int value, int index)
        {
            CheckIndexOutOfRangeException(index);
            if (index != 0)
            {
                Node crnt = _root;
                for (int i = 0; i < index - 1; i++)
                {
                    crnt = crnt.Next;
                }
                Node tmp = new Node(value);
                tmp.Next = crnt.Next;
                crnt.Next = tmp;
                Length++;
            }
            else
            {
                AddToFirst(value);
            }
        }

        public void AddByIndex(int[] addArray, int index)
        {
            CheckIndexOutOfRangeException(index);
            if (index != 0)
            {
                Node crnt = _root;
                for (int i = 0; i < index - 1; i++)
                {
                    crnt = crnt.Next;
                }

                LinkedList linkedList = new LinkedList(addArray);

                Node crntLL = linkedList._root;
                for (int i = 0; i < addArray.Length-1; i++)
                {
                    crntLL = crntLL.Next;
                }
                if (addArray.Length != 0)
                {
                    crntLL.Next = crnt.Next;
                    crnt.Next = linkedList._root;
                }
                Length += addArray.Length;
            }
            else
            {
                AddToFirst(addArray);
            }
        }

        public void DeleteLast(int amount = 1)
        {
            if (Length > amount)
            {
                Length -= amount;
            }
            else
            {
                Length = 0;
            }
        }

        public void DeleteFirst(int amount = 1)
        {
            if (Length > amount)
            {
                Node crnt = _root;
                for(int i = 0; i < amount-1; i++)
                {
                   crnt=crnt.Next;
                }
                _root = crnt.Next;
                Length -= amount;
            }
            else
            {
                Length = 0;
            }
        }

        public void DeleteByIndex(int index, int size = 1)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                DeleteFirst(size);
            }
            else
            {
                Node crnt = _root;
                for (int i = 0; i < index - 1; i++)
                {
                    crnt = crnt.Next;
                }

                if (size < Length - index)
                {
                    Node tmp = crnt;
                    for (int i = 0; i < size; i++)
                    {
                        crnt = crnt.Next;
                    }
                    tmp.Next = crnt.Next;
                    Length-=size;
                }
                else
                {
                    Length = index;
                }
            }
        }

        public int ReturnIndex(int element)
        {
            Node crnt = _root;
            for (int i = 0; i < Length; i++)
            {
                if (crnt.Value == element)
                {
                    return i;
                }
                crnt = crnt.Next;
            }
            throw new Exception("There isn't element");
        }

        public void Reverse()
        {
            if (Length == 0)
            {
                return;
            }
            Node oldRoot = _root;
            Node tmp;
            while (oldRoot.Next != null)
            {
                tmp = oldRoot.Next;
                oldRoot.Next = tmp.Next;
                tmp.Next = _root;
                _root = tmp;
            }
        }

        public int MaxValue()
        {
            CheckEmpty();
            Node crnt = _root;
            int max = crnt.Value;
            for (int i = 0; i < Length-1; i++)
            {
                crnt = crnt.Next;
                if (crnt.Value > max)
                {
                    max = crnt.Value;
                }
            }
            return max;
        }

        public int MinValue()
        {
            CheckEmpty();
            Node crnt = _root;
            int min = crnt.Value;
            for (int i = 0; i < Length - 1; i++)
            {
                crnt = crnt.Next;
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                }
            }
            return min;
        }

        public int FindIndexOfMinValue()
        {
            CheckEmpty();
            Node crnt = _root;
            int min = crnt.Value;
            int minInd = 0;
            for (int i = 0; i < Length - 1; i++)
            {
                crnt = crnt.Next;
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                    minInd = i + 1;
                }
            }
            return minInd;
        }

        public int FindIndexOfMaxValue()
        {
            CheckEmpty();
            Node crnt = _root;
            int max = crnt.Value;
            int maxInd = 0;
            for (int i = 0; i < Length - 1; i++)
            {
                crnt = crnt.Next;
                if (crnt.Value > max)
                {
                    max = crnt.Value;
                    maxInd = i + 1;
                }
            }
            return maxInd;
        }

        public void SortUp()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (this[j] < this[j - 1])
                    {
                        int k = this[j];
                        this[j] = this[j - 1];
                        this[j - 1] = k;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public void SortDown()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (this[j] > this[j - 1])
                    {
                        int k = this[j];
                        this[j] = this[j - 1];
                        this[j - 1] = k;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public void DeleteFirstValue(int value)
        {
            try
            {
                int index = ReturnIndex(value);
                DeleteByIndex(index);
            }
            catch
            {
            }  
        }

        public void DeleteAllValue(int value)
        {
            if (Length == 0)
            {
                return;
            }
            Node crnt = _root;
            Node tmp = crnt;
            while (tmp.Next!=null) 
            {
                if (crnt.Value == value)
                {
                    if (_root.Value == crnt.Value)
                    {
                        _root = crnt.Next;
                    }
                    else
                    {
                        tmp.Next = crnt.Next;
                    }
                    Length--;
                }
                else
                {
                    tmp = crnt;
                }
                crnt = crnt.Next;
            }

        }

        public override bool Equals(object obj)
        {
            LinkedList linkedList = (LinkedList)obj;
            if (Length != linkedList.Length)
            {
                return false;
            }

            Node tmp = _root;
            Node tmpObj = linkedList._root;
            for (int i = 0; i < Length; i++)
            {
                if (tmp.Value != tmpObj.Value)
                {
                    return false;
                }
                tmp = tmp.Next;
                tmpObj = tmpObj.Next;
            }
            return true;
        }

        public override string ToString()
        {
            string s = "";
            Node tmp = _root;
            for (int i = 0; i < Length; i++)
            {
                s += tmp.Value + ";";
                tmp = tmp.Next;
            }
            return s;
        }

        private void CheckEmpty()
        {
            if (Length == 0)
            {
                throw new Exception("Empty array");
            }
        }

        private void CheckIndexOutOfRangeException(int index)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
