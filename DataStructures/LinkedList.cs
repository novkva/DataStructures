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
                Node tmp = _root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp.Value;
            }
            set
            {
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
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
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
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
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
    }
}
