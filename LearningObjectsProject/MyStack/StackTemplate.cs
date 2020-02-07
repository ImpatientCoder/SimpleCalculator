using System;

namespace LearningObjectsProject
{
    class StackTemplate<T>
    {
        private int CurrentSize { get; set; }
        private int ArraySize { get; }

        private readonly T[] arr;


        public StackTemplate(int size)
        {
            ArraySize = size;
            arr = new T[ArraySize];
        }


        public void Push(T a)
        {
            if (CurrentSize >= ArraySize)
            {
                Console.WriteLine("Stack overflow...!!");
                return;
            }
            else
            {
                arr[CurrentSize] = a;
                CurrentSize++;
                return;
            }
        }


        public T Pop()
        {
            T temp;
            if (CurrentSize > 0)
            {
                temp = arr[CurrentSize - 1];
                CurrentSize--;
            }
            else
                return default;

            return temp;
        }


        public T Pick() => CurrentSize > 0 ? arr[CurrentSize - 1] : (default);
    }
}




