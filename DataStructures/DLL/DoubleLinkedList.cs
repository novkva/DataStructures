using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DLL
{
    public class DoubleLinkedList
    {
        public int Length { get; private set; }
        private Node _head;
        private Node _tail;

        public DoubleLinkedList()
        {
            Length = 0;
            _head = null;
            _tail = null;
        }

        public DoubleLinkedList(int value)
        {
            Length = 1;
            _head = new Node(value);
            _tail = _head;
        }

        public DoubleLinkedList(int[] array)
        {
            Length = array.Length;
            if (Length != 0)
            {
                _head = new Node (array[0]);
                Node crnt = _head;
                for (int i = 1; i < Length; i++)
                {
                    crnt.Next = new Node(array[i]);
                    Node tmp = crnt;
                    crnt = crnt.Next;
                    crnt.Previous = tmp;
                }
                _tail = crnt;
            }
            else
            {
                _head = null;
                _tail = null;
            }
        }

        public int this[int index]
        {
            get
            {
                CheckIndexOutOfRangeException(index);
                if (CheckFirstHalf(index))
                {
                    Node tmp = _head;
                    for (int i = 0; i < index; i++)
                    {
                        tmp = tmp.Next;
                    }
                    return tmp.Value;
                }
                else
                {
                    Node tmp = _tail;
                    for (int i = Length-1; i > index; i--)
                    {
                        tmp = tmp.Previous;
                    }
                    return tmp.Value;
                }
            }
            set
            {
                CheckIndexOutOfRangeException(index);
                if (CheckFirstHalf(index))
                {
                    Node tmp = _head;
                    for (int i = 0; i < index; i++)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Value = value;
                }
                else
                {
                    Node tmp = _tail;
                    for (int i = Length - 1; i > index; i--)
                    {
                        tmp = tmp.Previous;
                    }
                    tmp.Value = value;
                }
            }
        }

        public void Add(int value)
        {
            //Node tmp= new Node(value);
            //if (Length != 0) 
            //{
            //    _tail.Next = tmp;
            //    tmp.Previous = _tail;
            //    _tail = tmp;
            //}
            //else
            //{
            //    _head = new Node(value);
            //    _tail = _head;
            //}
            //Length++;
            Add(new int[] { value});
        }

        public void Add(int[] array)
        {
            if (array.Length == 0)
            {
                return;
            }

            DoubleLinkedList linkedList = new DoubleLinkedList(array);
            if (Length != 0)
            {
                _tail.Next = linkedList._head;
                linkedList._head.Previous = _tail;
            }
            else
            {
                _head = linkedList._head;
            }
            _tail = linkedList._tail;

            Length += array.Length;
        }

        public void AddToFirst(int value)
        {
            //Node tmp = new Node(value);
            //if (Length != 0)
            //{
            //    tmp.Next = _head;
            //    _head.Previous = tmp;
            //}
            //else
            //{
            //    _tail = tmp;
            //}
            //_head = tmp;
            //Length++;

            AddToFirst(new int[] { value});
        }

        public void AddToFirst(int[] array)
        {
            if (array.Length == 0)
            {
                return;
            }

            DoubleLinkedList linkedList = new DoubleLinkedList(array);
            if (Length != 0)
            {
                linkedList._tail.Next = _head;
                _head.Previous = linkedList._tail;
            }
            else
            {
                _tail = linkedList._tail;
            }
            _head = linkedList._head;

            Length += array.Length;
        }

        public void AddByIndex(int value, int index)
        {
            CheckIndexOutOfRangeException(index-1);

        }

        public void AddByIndex(int[] array, int index)
        {
            CheckIndexOutOfRangeException(index - 1);
            if (index == Length)
            {
                Add(array);
                return;
            }
            if (index == 0)
            {
                AddToFirst(array);
                return;
            }
            if (array.Length == 0)
            {
                return;
            }
            DoubleLinkedList ll = new DoubleLinkedList(array);
            if (CheckFirstHalf(index))
            {
                Node crnt = _head;
                for (int i = 0; i < index - 1; i++)
                {
                    crnt = crnt.Next;
                }
                Node tmp;

                crnt.Next = ll._head;
                ll._head.Previous = crnt;
            }
            else
            {
                Node crnt = _tail;
                for (int i = Length - 1; i > index ; i--)
                {
                    crnt = crnt.Previous;
                }
            }
            

        }

        public override bool Equals(object obj)
        {
            DoubleLinkedList linkedList = (DoubleLinkedList)obj;
            if (Length != linkedList.Length)
            {
                return false;
            }

            Node tmp = _head;
            Node tmpObj = linkedList._head;
            for (int i = 0; i < Length; i++)
            {
                if (tmp.Value != tmpObj.Value)
                {
                    return false;
                }
                tmp = tmp.Next;
                tmpObj = tmpObj.Next;
            }

            tmp = _tail;
            tmpObj = linkedList._tail;
            for (int i = 0; i < Length; i++)
            {
                if (tmp.Value != tmpObj.Value)
                {
                    return false;
                }
                tmp = tmp.Previous;
                tmpObj = tmpObj.Previous;
            }
            return true;
        }

        public override string ToString()
        {
            string s = "";
            Node tmp = _head;
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

        private bool CheckFirstHalf(int index)
        {
            return index < Length / 2;
        }
    }
}
