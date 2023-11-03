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
            //Вывод массива
            Console.WriteLine("Ваша дата: ");
            for (int i = 0; i < datamas.Length; i++)
            {
                Console.Write(datamas[i]);
            }
            Console.WriteLine(" ");
            int sum = 0;

            for (int i = 0; i < datamas.Length; i++)
            {
                sum += datamas[i];
            }

            Console.WriteLine("Первое рабочее число: " + sum);
            int vch = sum;
            string summ = sum.ToString();
            int[] summas = new int[summ.Length];

            //массив даты
            summas[0] = int.Parse(summ.Substring(0, 1));
            //массив из string переводим в int
            for (int i = 1; i < summ.Length; i++)
            {
                summas[i] += int.Parse(summ.Substring(i, 1));
            }
            int sumtwo = 0;

            for (int i = 0; i < summas.Length; i++)
            {
                sumtwo += summas[i];
            }

            Console.WriteLine("Второе рабочее число: " + sumtwo);
            int sumthree = vch - datamas[0] * 2; 
            Console.WriteLine("Третье рабочее число: " + sumthree);

            string sam = sumthree.ToString();
            int[] sammas = new int[sam.Length];

            sammas[0] = int.Parse(sam.Substring(0, 1));
            for (int i = 1; i < sam.Length; i++)
            {
                sammas[i] += int.Parse(sam.Substring(i, 1));
            }
            int sumfour = 0;

            for (int i = 0; i < sammas.Length; i++)
            {
                sumfour += sammas[i];
            }
            Console.WriteLine("Второе рабочее число: " + sumfour);


            Console.ReadLine();
            
        }
    }
}

