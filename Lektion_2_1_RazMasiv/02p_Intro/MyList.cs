using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02p_Intro
{
    public class MyList<T>
    {
        private T[] data;
        private int count;

        public MyList()
        {
            
        }

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }


        //Позволява ни да достъпваме елементите по индекс
        public T this[int index]
        {
            get
            {
                ValdateIndex(index);
                return data[index]; }
            set
            {
                ValdateIndex(index);
                data[index] = value;
            }
        }

        //Добавяне на елемент към структурата от данни
        public void Add(T item)
        {
            if (data==null)
            {
                data = new T[4];
            }

            checkCapacity();
            data[count] = item;
            count++;
        }

        //Метод за дължина на СД
        public int Capacity()
        {
            return this.data.Length;
        }

        //Метод за създаване на нов array   с двойно по-голяма дължина
        private void checkCapacity()
        {
            if (data.Length==Count)
            {
                T[] newDataArr = new T[2 * data.Length];

                //Преливане от малкия масив в големият
                for (int i = 0; i < data.Length; i++)
                {
                    newDataArr[i] = data[i];
                }

                //Променяме референцията да сочи към новата
                data = newDataArr;
            }
        }

        //Метод само за класа, който проверява дали излизаме извън дължината на запълнената СД
        private void ValdateIndex(int index)
        {
            if (index>=count)
            {
                throw new ArgumentOutOfRangeException("Check the index");
            }
        }
        
        //Метод за изтриване по индекс-TODO.......

    }
}
