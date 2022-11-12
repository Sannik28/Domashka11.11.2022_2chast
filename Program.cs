using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domashka11._11._2022_2chast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Задание 1
Пользователь вводит с клавиатуры число в диапазоне от 1 до 100.Если число кратно 3(делится на 3 без
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
вывести само число.
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке
            */
            /*
            int a;
            Console.WriteLine("Ведите число от 1 до 100");
            do
            {
                a = int.Parse(Console.ReadLine());
                if (a<0||a>100) { Console.WriteLine("Ошибка ввода. Повторите вод числа от 1 до 100"); }
            } while (a < 0||a>100);
            if (a % 3 == 0&&a%5==0)
                Console.WriteLine("Fizz Buzz");
            else if (a% 3 == 0)
                Console.WriteLine("Fizz");
            else if (a % 5 == 0)
                Console.WriteLine("Buzz");
            else                     
                Console.WriteLine(a);
                Console.ReadLine();
              */
            /*
            Задание 2
            Пользователь вводит с клавиатуры два числа. Первое
            число — это значение, второе число процент, который
            необходимо посчитать. Например, мы ввели с клавиатуры
            90 и 10.Требуется вывести на экран 10 процентов от 90.
            Результат: 9.
            */
            /*
            int b, p, proc;
            Console.WriteLine("Ведите число ");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите вычисляемый процент");
            p = int.Parse(Console.ReadLine());
            proc = b * p / 100;
            Console.WriteLine(p +"% от "+b+" составляет "+proc);
            Console.ReadLine();
            */
            /*
            Задание 3
            Пользователь вводит с клавиатуры четыре цифры. 
            Необходимо создать число, содержащее эти цифры.Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
            сформировать число 1578
            */
            /*
            string a1, a2, a3, a4;
            Console.WriteLine("Введите число 1: ");
            a1=Console.ReadLine();
            Console.WriteLine("Введите число 2: ");
            a2 = Console.ReadLine();
            Console.WriteLine("Введите число 3: ");
            a3 = Console.ReadLine();
            Console.WriteLine("Введите число 4: ");
            a4 = Console.ReadLine();
            Console.WriteLine(a1+a2+a3+a4);
            Console.ReadLine();*/
            /*  Задание 4
            Пользователь вводит шестизначное число. После чего
            пользователь вводит номера разрядов для обмена цифр.
            Например, если пользователь ввёл один и шесть — это
            значит, что надо обменять местами первую и шестую
            цифры.
            Число 723895 должно превратиться в 523897.
            Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.
            */
            /*
            int str, temp;
            Console.WriteLine("Введите шестизначное число");
            do
            {
                str = int.Parse(Console.ReadLine());
                if (str > 999999 || str <100000)
                {
                    Console.WriteLine("Ошибка ввода. Повторите ввод.");
                }
            } while (str > 999999 || str < 100000);
            int[] nums = new int[6];
            nums[0] = str / 100000;
            int sth1 = str % 100000;
            nums[1] = sth1 / 10000;
            int dth1 = sth1 % 10000;
            nums[2] = dth1 / 1000;
            int th1 = dth1 % 1000;
            nums[3] = th1/ 100;
            int s1=th1% 100;
            nums[4] = s1 / 10;
            nums[5] = s1 % 10;
            Console.WriteLine("Введите 1ю цифру для замены");
            int c1=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2ю цифру для замены");
            int c2 = int.Parse(Console.ReadLine());
            temp = nums[c1 - 1 ];
            nums[c1-1] = nums[c2-1];
            nums[c2-1] = temp;
            int step=100000;
            str = 0;
            for (int i=0; i<6; i++)
            {
                str += nums[i] * step;
                step = step/10;
            }
            Console.WriteLine(str);
            Console.ReadKey();
            // надо было наверное int.Parse(new string(Console.ReadLine().ToArray())));
            // или string[]arr = Console.ReadLine().Split();
            */
            /*  Задание 4 Пользователь вводит с клавиатуры дату.Приложение должно отобразить название сезона и дня недели. 
            Например, если введено 22.12.2021, приложение должно
            отобразить Winter Wednesday.*/

            /*
            DateTime date;
                Console.WriteLine("Введите дату в формате дд.мм.гггг");
               date = DateTime.Parse(Console.ReadLine());
                int month = date.Month;
                if (month < 3 || month == 12) { Console.WriteLine("Winter "); }
                else if (month > 3 && month < 6) { Console.WriteLine("Spring "); }
                else if (month > 6 && month < 9) { Console.WriteLine("Summer "); }
                else { Console.WriteLine("Autumn "); }
                Console.WriteLine(date.DayOfWeek);
                Console.ReadKey();
            */

            /*
           Задание 6
Пользователь вводит с клавиатуры показания температуры.В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий
или наоборот.
           */
            /*
            Console.WriteLine("Введите показания темпертуры");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 1 для перевода в фаренгейты. Введите 2 для перевода в градусы цельсия.");
            int v=int.Parse(Console.ReadLine());
            if (v == 1) {
                t = t * 9 / 5 + 32;
                Console.WriteLine("Температура по Фаренгейту равна: {0}", t);
                Console.ReadKey();
            }
            else {
                t = (t-32) * 5 / 9;
                Console.WriteLine("Температура по Фаренгейту равна: {0}", t);
                Console.ReadKey();
            }
            */

            /*
Задание 7
Пользователь вводит с клавиатуры два числа. Нужно
показать все четные числа в указанном диапазоне. Если
границы диапазона указаны неправильно требуется произвести нормализацию границ.Например, пользователь
ввел 20 и 11, требуется нормализация, после которой
начало диапазона станет равно 11, а конец 20
            */
            Console.WriteLine("Введите 1 число диапазона");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число диапазона");
            int n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp;
            }
            for (int i=n1; i<=n2; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i);}
            }
            Console.ReadKey();





        }
    }
}
