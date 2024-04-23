using System;

namespace ImplementationApp
{
    internal class Stack<T>
    {
        private T[] items;
        private int count = 0;

        public Stack() 
        {
            items = Array.Empty<T>();
        }

        /// <summary>
        /// Добавление нового элемента в стек
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            if (items.Length == count)
                Resize(items.Length + 1);

            items[count++] = item;
        }

        /// <summary>
        /// Удаление последнего элемента из стека
        /// </summary>
        public T Pop()
        {
            T popItem = items[--count];

            items[count] = default;

            Resize(count);

            return popItem;
        } 

        /// <summary>
        /// Получение последнего элемента из стека
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return items[count - 1];
        }

        public void ClearAll()
        {
            count = 0;
            items = Array.Empty<T>();
        }

        /// <summary>
        /// Является ли стек пустым
        /// </summary>
        /// <returns></returns>
        public Boolean isEmpty
        {
            get { return count == 0; }
        }

        /// <summary>
        /// Количесвто элементов в стеке
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Увеличиваем размер массива динамически
        /// </summary>
        /// <param name="newLength"></param>
        private void Resize(int newLength)
        {
            T[] newItemsArray = new T[newLength];

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                    newItemsArray[i] = items[i];
            }

            items = newItemsArray;
        }

        /// <summary>
        /// Удобный вывод текущего состояния стека
        /// </summary>
        public void printStack()
        {
            Console.WriteLine("===========================");

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }

            Console.WriteLine("Является ли стек пустым = " + this.isEmpty);
            Console.WriteLine("Кол-во элементов в стеке = " + this.Count);

            Console.WriteLine("===========================");
        }
    }

    public static class StackMain
    {
        public static void RunStackImplementation()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");

            stack.printStack();

            Console.WriteLine("Удаление последнего элемента из стека = " + stack.Pop());

            Console.WriteLine("Верхний элeмент стека = " + stack.Peek());

            stack.ClearAll();

            stack.printStack();

            stack.Push("A");
            stack.Push("B");

            stack.printStack();

            Console.WriteLine("Верхний элeмент стека = " + stack.Peek());

            Console.WriteLine("Удаление последнего элемента из стека = " + stack.Pop());

            Console.WriteLine("Верхний элeмент стека = " + stack.Peek());
        }            
    }
}
