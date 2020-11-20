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
            _array[0] = element;
            Length = 1;
        }

        public ArrayList(int[] _array)
        {
            Length = _array.Length;
            this._array = new int[Length + (int)(Length * 0.34d)];
            Array.Copy(_array, this._array, Length);
        }

        public int this[int index]
        {
            get
            {
                CheckArgumentOutOfRangeException(index);
                return _array[index];
            }
            set
            {
                CheckArgumentOutOfRangeException(index);
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
            RizeSize();
            _array[Length] = element;
            Length++;
        }

        public void Add(int[] addArray)
        {
            RizeSize(addArray.Length);
            for (int i = 0; i < addArray.Length; i++)
            {
                _array[Length] = addArray[i];
                Length++;
            }
        }

        public void AddToFirst(int element)
        {
            RizeSize();
            MoveElements();
            Length++;
            _array[0] = element;
        }

        public void AddToFirst(int[] addArray)
        {
            RizeSize(addArray.Length);
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
            RizeSize();
            MakePlace(index);
            Length++;
            _array[index] = element;

        }

        public void AddByIndex(int[] array, int index)
        {
            CheckArgumentOutOfRangeException(index);
            RizeSize(array.Length);

            MakePlace(index, array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                _array[index + i] = array[i];
                Length++;
            }
        }

        public void DeleteLast(int amount = 1)
        {
            if (Length >= amount)
            {
                Length -= amount;
            }
            else
            {
                Length = 0;
            }
            
                DecreaseSize();
            
        }

        public void DeleteFirst(int amount = 1)
        {
            for (int i = 0; i < Length - amount; i++)
            {
                _array[i] = _array[i + amount];
            }
            if (Length >= amount)
            {
                Length -= amount;
            }
            else
            {
                Length = 0;
            }
            DecreaseSize();
        }

        public void DeleteByIndex(int index, int size = 1)
        {
            CheckArgumentOutOfRangeException(index);
            if (size > Length - index)
            {
                size = Length - index;
            }
            for (int i = index; i < Length - size; i++)
            {
                _array[i] = _array[i + size];
            }
            Length -= size;
            DecreaseSize();
        }

        public int ReturnIndex(int element)
        {
            for (int i = 0; i < Length; i++)
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
            CheckEmpty();
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
            CheckEmpty();
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
            CheckEmpty();
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
            CheckEmpty();
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
            for (int i = 0; i < Length - 1; i++)
            {
                int tmp;
                for (int j = 1; j < Length - i; j++)
                {
                    if (_array[j] < _array[j - 1])
                    {
                        tmp = _array[j];
                        _array[j] = _array[j - 1];
                        _array[j - 1] = tmp;
                    }
                }
            }
        }

        public void SortDown()
        {
            for (int i = 0; i < Length - 1; i++)
            {
                int max = _array[i];
                int indMax = i;

                for (int j = i; j < Length; j++)
                {
                    if (_array[j] > max)
                    {
                        max = _array[j];
                        indMax = j;
                    }
                }
                int k = _array[i];
                _array[i] = max;
                _array[indMax] = k;
            }
        }

        public void DeleteFirstValue(int value)
        {
            int tmp = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value && tmp == 0)
                {
                    tmp = 1;
                }
                else
                {
                    _array[i - tmp] = _array[i];
                }
            }
            Length -= tmp;
        }

        public void DeleteAllValue(int value)
        {
            int tmp = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    tmp++;
                }
                else
                {
                    _array[i - tmp] = _array[i];
                }
            }
            Length -= tmp;
            DecreaseSize();
        }

        private void RizeSize(int size = 1)
        {
            if (_array.Length <= Length + size)
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
        }

        private void MoveElements(int amount = 1)
        {
            int[] newArray = new int[_array.Length];
            Array.Copy(_array, 0, newArray, amount, Length);
            _array = newArray;
        }

        private void MakePlace(int startIndex, int size = 1)
        {
            int[] newArray = new int[_array.Length];
            Array.Copy(_array, 0, newArray, 0, startIndex);
            Array.Copy(_array, startIndex, newArray, startIndex + size, Length - startIndex);
            _array = newArray;
        }

        private void DecreaseSize()
        {
            if (Length <= _array.Length / 2)
            {
                int newLength = _array.Length;
                while (newLength >= Length * 2 && newLength > 3)
                {
                    newLength = (int)(newLength * 0.67d);
                }
                int[] newArray = new int[newLength];
                Array.Copy(_array, newArray, newLength);
                _array = newArray;
            }
        }

        private void CheckEmpty()
        {
            if (Length == 0)
            {
                throw new Exception("Empty array");
            }
        }

        private void CheckArgumentOutOfRangeException(int index)
        {
            if (index >= Length || index < 0)
            {
                throw new ArgumentOutOfRangeException("Incorrect index");
            }
        }
    }
}
