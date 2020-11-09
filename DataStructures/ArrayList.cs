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
            MakePlace(ind);
            _array[ind] = element;

        }

        public void DeleteLast()
        {
            DeleteIndex(Length - 1);
            //DeleteOneElement(0);
            //if (Length <= _array.Length/2)
            //{
            //    DecreaseSize();
            //}
        }

        public void DeleteFirst()
        {
            DeleteIndex(0);
            //DeleteOneElement(1);
            //if(Length <= _array.Length / 2)
            //{
            //    DecreaseSize();
            //}
        }

        public void DeleteIndex(int index)
        {
            if (index >= Length)
            {
                throw new Exception("Incorrect index");
            }
            int[] newArray = new int[_array.Length];
            Array.Copy(_array, 0, newArray, 0, index);
            Array.Copy(_array, index+1, newArray, index, Length-index -1);
            Length--;
            _array = newArray;
            if (Length <= _array.Length / 2)
            {
                DecreaseSize();
            }
        }

        public int ReturnElement(int index)
        {
            if (index>= Length)
            {
                throw new Exception("Incorrect index");
            }
            return _array[index];
        }

        public int ReturnIndex(int element)
        {
            for (int i=0; i < Length; i++)
            {
                if (_array[i] == element)
                {
                    return i;
                }
            }
            throw new Exception("There isn't element");
        }

        public void ChangeElement(int index, int value)
        {
            if (index >= Length)
            {
                throw new Exception("There isn't index");
            }
            _array[index] = value;
        }

        public void Reverse()
        {
            for (int i = 0; i < Length / 2; i++)
            {
                int j = _array[Length - 1 - i];
                _array[Length - 1 - i] = _array[i];
                _array[i] = j;
            }
        }

        private void DeleteOneElement(int start)
        {
            //int[] newArray = new int[_array.Length];
            //Array.Copy(_array, start, newArray, 0, Length - 1);
            //Length--;
            //_array = newArray;

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

        private void MakePlace(int startIndex, int size=1)
        {
            int[] newArray = new int[_array.Length];
            Array.Copy(_array, 0, newArray, 0, startIndex);
            Array.Copy(_array, startIndex, newArray, startIndex+size, Length-startIndex);
            _array = newArray;
        }

        private void DecreaseSize(int size = 1)
        {
            int newLength = _array.Length;
            while (newLength >= Length*2 && newLength >3)
            {
                newLength = (int)(newLength * 0.67d);
            }
            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, newLength);
            _array = newArray;
        }
    }
}
