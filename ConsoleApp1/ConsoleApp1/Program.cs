using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricaPifagora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Переменная для ввода даты
            string data;
            int datasum = 0;
            Console.WriteLine("Введите дату без использования вспомогательных знаков Пример:13122005");
            data = Console.ReadLine();
            int[] datamas = new int[data.Length];
            
            //массив даты
            datamas[0] = int.Parse(data.Substring(0, 1));
            //массив из string переводим в int
            for (int i= 1; i < data.Length; i++)
            {
                datamas[i] += int.Parse(data.Substring(i, 1));
            }
            //Заполняем массив
            /*for (int i = 0; i < data.Length; i++)
            {
                 summas[i] = data[i];
            }*/
            //Вывод массива
            Console.WriteLine("Массив: ");
            for (int i = 0; i < datamas.Length; i++)
            {
                Console.Write(datamas[i]);
            }

            int[] summas = new int [data.Length];
            
            Console.ReadLine();
            // Инициализация переменной и массива
            /*string pervoest = pervoe.ToString();
            char[] array = new char[pervoest.Length];

            // Перенос данных
            for (int i = 0; i < pervoest.Length; i++)
            {
                array[i] = pervoest[i];
            }

            // Использование массива после переноса данных
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.ReadLine();
            */
        }
    }
}

