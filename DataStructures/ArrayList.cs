using System;

namespace DataStructures
{
    public class ArrayList
    {
        public int Length { get; private set; }
        private int[] _array;

        public ArrayList()
        {
            _array = new int[3];
            Length = 0;
        }


        //think
        public ArrayList(int length)
        {
            Length = length;
            _array = new int[3];
        }

        public ArrayList(int[] _array)
        {
            Length = _array.Length;
            this._array = new int[Length];//+(int)(Length*1.33d)];
            Array.Copy(_array, this._array, Length);  
        }

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;
            if (arrayList == null) return false;
            if (arrayList.Length != this.Length) return false;
            for (int i = 0; i < Length; i++)
            {
                if (arrayList._array[i] != this._array[i]) return false;
            }
            return true;
        }

        public void Add(int element)
        {
            if (_array.Length <= Length)
            {
                RizeSize();
            }
            _array[Length] = element;
            Length++;
        }

        public void AddToFirst(int element)
        {
            if (_array.Length <= Length)
            {
                RizeSize();
            }
            Length++;
            //int[] newArray = new int[_array.Length];
            //Array.Copy(_array, 0, newArray, 1, Length);
            //newArray[0] = element;
            //_array = newArray;
            MoveElements();
            _array[0] = element;
            
        }

        public void AddByIndex(int element, int ind)
        {
            if (_array.Length <= Length)
            {
                RizeSize();
            }
            Length++;
            int[] newArray = new int[_array.Length];
            Array.Copy(_array, 0, newArray, 1, Length);
            newArray[0] = element;
            _array = newArray;

        }

        private void RizeSize(int size=1)
        {
            int newLength = _array.Length;
            while (newLength < _array.Length + size)
            {
                newLength = (int)(newLength * 1.33d + 1);
            }
            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, _array.Length);
            _array = newArray;
        }

        private void MoveElements(int amount=1)
        {
            int[] newArray = new int[_array.Length];
            Array.Copy(_array, 0, newArray, amount, Length);
            _array = newArray;
        }
    }
}
