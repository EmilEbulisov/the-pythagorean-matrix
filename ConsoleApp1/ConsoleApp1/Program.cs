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
            Console.WriteLine("Четвертое рабочее число: " + sumfour);
            //Теперь считаем матрицу
            int tens = sum / 10;
            int units = sum % 10;

            int tens2 = sumtwo / 10;
            int units2 = sumtwo % 10;

            int tens3 = sumthree / 10;
            int units3 = sumthree % 10;

            int tens4 = sumfour / 10;
            int units4 = sumfour % 10;

            int b1 = 0;
            int b2 = 0;
            int b3 = 0;
            int b4 = 0;
            int b5 = 0;
            int b6 = 0;
            int b7 = 0;
            int b8 = 0;
            int b9 = 0;
            //Проверяем десятки первого числа
            if (tens == 1)
            {
                b1++;
            }
            else if (tens == 2)
            {
                b2++;
            }
            else if (tens == 3)
            {
                b3++;
            }
            else if (tens == 4)
            {
                b4++;
            }
            else if (tens == 5)
            {
                b5++;
            }
            else if (tens == 6)
            {
                b6++;
            }
            else if (tens == 7)
            {
                b7++;
            }
            else if (tens == 8)
            {
                b8++;
            }
            else if (tens == 9)
            {
                b9++;
            }
            
            //Проверяем десятки второго числа
            if (tens2 == 1)
            {
                b1++;
            }
            else if (tens2 == 2)
            {
                b2++;
            }
            else if (tens2 == 3)
            {
                b3++;
            }
            else if (tens2 == 4)
            {
                b4++;
            }
            else if (tens2 == 5)
            {
                b5++;
            }
            else if (tens2 == 6)
            {
                b6++;
            }
            else if (tens2 == 7)
            {
                b7++;
            }
            else if (tens2 == 8)
            {
                b8++;
            }
            else if (tens2 == 9)
            {
                b9++;
            }
            //desatki 3
            //Проверяем десятки второго числа
            if (tens3 == 1)
            {
                b1++;
            }
            else if (tens3 == 2)
            {
                b2++;
            }
            else if (tens3 == 3)
            {
                b3++;
            }
            else if (tens3 == 4)
            {
                b4++;
            }
            else if (tens3 == 5)
            {
                b5++;
            }
            else if (tens3 == 6)
            {
                b6++;
            }
            else if (tens3 == 7)
            {
                b7++;
            }
            else if (tens3 == 8)
            {
                b8++;
            }
            else if (tens3 == 9)
            {
                b9++;
            }
            //desatki4
            //Проверяем десятки второго числа
            if (tens4 == 1)
            {
                b1++;
            }
            else if (tens4 == 2)
            {
                b2++;
            }
            else if (tens4 == 3)
            {
                b3++;
            }
            else if (tens4 == 4)
            {
                b4++;
            }
            else if (tens4 == 5)
            {
                b5++;
            }
            else if (tens4 == 6)
            {
                b6++;
            }
            else if (tens4 == 7)
            {
                b7++;
            }
            else if (tens4 == 8)
            {
                b8++;
            }
            else if (tens4 == 9)
            {
                b9++;
            }
            //Проверяем единицы первого числа
            if (units == 1)
            {
                b1++;
            }
            else if (units == 2)
            {
                b2++;
            }
            else if (units == 3)
            {
                b3++;
            }
            else if (units == 4)
            {
                b4++;
            }
            else if (units == 5)
            {
                b5++;
            }
            else if (units == 6)
            {
                b6++;
            }
            else if (units == 7)
            {
                b7++;
            }
            else if (units == 8)
            {
                b8++;
            }
            else if (units == 9)
            {
                b9++;
            }
            //Проверяем единицы второго числа
            if (units2 == 1)
            {
                b1++;
            }
            else if (units2 == 2)
            {
                b2++;
            }
            else if (units2 == 3)
            {
                b3++;
            }
            else if (units2 == 4)
            {
                b4++;
            }
            else if (units2 == 5)
            {
                b5++;
            }
            else if (units2 == 6)
            {
                b6++;
            }
            else if (units2 == 7)
            {
                b7++;
            }
            else if (units2 == 8)
            {
                b8++;
            }
            else if (units2 == 9)
            {
                b9++;
            }
            //edinici 3
            if (units3 == 1)
            {
                b1++;
            }
            else if (units3 == 2)
            {
                b2++;
            }
            else if (units3 == 3)
            {
                b3++;
            }
            else if (units3 == 4)
            {
                b4++;
            }
            else if (units3 == 5)
            {
                b5++;
            }
            else if (units3 == 6)
            {
                b6++;
            }
            else if (units3 == 7)
            {
                b7++;
            }
            else if (units3 == 8)
            {
                b8++;
            }
            else if (units3 == 9)
            {
                b9++;
            }
            //edinici 4
            if (units4 == 1)
            {
                b1++;
            }
            else if (units4 == 2)
            {
                b2++;
            }
            else if (units4 == 3)
            {
                b3++;
            }
            else if (units4 == 4)
            {
                b4++;
            }
            else if (units4 == 5)
            {
                b5++;
            }
            else if (units4 == 6)
            {
                b6++;
            }
            else if (units4 == 7)
            {
                b7++;
            }
            else if (units4 == 8)
            {
                b8++;
            }
            else if (units4 == 9)
            {
                b9++;
            }
            Console.WriteLine("Однёрок = " + b1 + "\n Двоек = " + b2 + "\n Троек = " + b3 + "\n Четвёрок = " + b4 + "\n Пятёрок = " + b5 + "\n Шестёрок = " + b6 + "\n Семёрок = " + b7 + "\n Восьмёрок = " + b8 + "\n Девяток = " + b9);
            Console.ReadLine();
            
        }
    }
}

