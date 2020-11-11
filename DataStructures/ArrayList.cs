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

        public ArrayList(int element)
        {
            this._array = new int[3];
            _array[0] =  element;
            Length = 1;
        }

        public ArrayList(int[] _array)
        {
            Length = _array.Length;
            this._array = new int[Length+(int)(Length*0.34d)];
            Array.Copy(_array, this._array, Length);  
        }

        public int this[int index]
        {
            get
            {
                if (index >= Length || index < 0)
                {
                    throw new Exception("Incorrect index");
                }
                return _array[index];
            }
            set
            {
                if (index >= Length || index < 0)
                {
                    throw new Exception("Incorrect index");
                }
                _array[index] = value;
            }
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

        public void Add(int[] addArray)
        {
            if ((Length + addArray.Length) >= _array.Length)
            {
                RizeSize(addArray.Length);
            }
            for (int i = 0; i < addArray.Length; i++)
            {
                _array[Length] = addArray[i];
                Length++;
            }
        }


        public void AddToFirst(int element)
        {
            if (_array.Length <= Length)
            {
                RizeSize();
            }
            MoveElements();
            Length++;
            _array[0] = element;
            
        }

        public void AddToFirst(int[] addArray)
        {
            if ((Length + addArray.Length) >= _array.Length)
            {
                RizeSize(addArray.Length);
            }
            MoveElements(addArray.Length);
            for (int i = 0; i < addArray.Length; i++)
            {
                _array[i] = addArray[i];
                Length++;
            }
        }

        //можно выходить за границы массива, если добавляем элемент в конец, если нет, то index >= Length 
        public void AddByIndex(int element, int index)
        {
            if (index > Length || index < 0)
            {
                throw new ArgumentOutOfRangeException("Incorrect index");
            }
            if (_array.Length <= Length)
            {
                RizeSize();
            }
            MakePlace(index);
            Length++;
            _array[index] = element;

        }

        public void AddByIndex(int[] array, int index)
        {
            if (index >= Length || index < 0)
            {
                throw new ArgumentOutOfRangeException("Incorrect index");
            }
            if ((Length + array.Length) >= _array.Length)
            {
                RizeSize(array.Length);
            }

            MakePlace(index, array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                _array[index+i] = array[i];
                Length++;
            }

        }

        public void DeleteLast()
        {
            //DeleteIndex(Length - 1);
            if(Length != 0)
            {
                Length--;
            }
            
        }

        public void DeleteLast(int amount)
        {
            //DeleteIndex(Length - 1)
            if (Length <= amount)
            {
                Length = 0;
            }
            else if (amount != 0)
            {
                DeleteByIndex(Length - amount, amount);
            }

        }

        public void DeleteFirst()
        {
            if (Length != 0)
            {
                DeleteByIndex(0);
            }
        }

        public void DeleteFirst(int amount)
        {
            if (Length <= amount)
            {
                Length = 0;
            }
            else
            {
                DeleteByIndex(0, amount);
            }
        }

        public void DeleteByIndex(int index, int size = 1)
        {
            if (index >= Length || index < 0)
            {
                throw new Exception("Incorrect index");
            }
            int[] newArray = new int[_array.Length];
            Array.Copy(_array, 0, newArray, 0, index);
            Array.Copy(_array, index+size, newArray, index, Length-index -size);
            Length-=size;
            _array = newArray;
            if (Length <= _array.Length / 2)
            {
                DecreaseSize();
            }
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

        public void Reverse()
        {
            for (int i = 0; i < Length / 2; i++)
            {
                int j = _array[Length - 1 - i];
                _array[Length - 1 - i] = _array[i];
                _array[i] = j;
            }
        }

        public int MaxValue()
        {
            if (Length == 0)
            {
                throw new Exception("Empty array");
            }
            int max = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }

        public int MinValue()
        {
            if (Length == 0)
            {
                throw new Exception("Empty array");
            }
            int min = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
        }

        public int FindIndexOfMinValue()
        {
            if (Length == 0)
            {
                throw new Exception("Empty array");
            }
            int minInd = 0;
            int min = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    minInd = i;
                    min = _array[i];
                }
            }
            return minInd;
        }

        public int FindIndexOfMaxValue()
        {
            if (Length == 0)
            {
                throw new Exception("Empty array");
            }
            int maxInd = 0;
            int max = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    maxInd = i;
                    max = _array[i];
                }
            }
            return maxInd;
        }

        public void SortUp()
        {

        }

        public void SortDown()
        {

        }

        public void DeleteFirstValue(int value)
        {
            for(int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    DeleteByIndex(i);
                    break;
                }
            }
        }

        public void DeleteAllValue(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    DeleteByIndex(i);
                    i--;
                }
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
