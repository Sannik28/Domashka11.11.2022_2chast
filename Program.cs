using System;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

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
            /*
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
            */
            /*
             //не суцдите строго мы еще этого не проходили
             
             
            Задание 1
Объявить одномерный(5 элементов) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел с именем B.Заполнить одномерный массив
А числами, введенными с клавиатуры пользователем, а
двумерный массив В случайными числами с помощью
циклов.Вывести на экран значения массивов: массива
А в одну строку, массива В — в виде матрицы.Найти в
данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
произведение всех элементов, сумму четных элементов
массива А, сумму нечетных столбцов массива В.
            */
            /*
            double max, min, sum=0, proiz=1, sumChetA=0, sumNechColB=0;
            int[] A = new int[5];
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Введите элемент массива "+(i+1));
                A[i] = int.Parse(Console.ReadLine());           
            }
            foreach (int i in A)
            {
                Console.Write(" "+i);
            }
            Console.Write("\n");
            max = A[0];
            min = A[0];
            for (int i = 0; i < A.Length; i++)
            {              
                if (A[i]>max) max = A[i];
                else if (A[i] < min) min = A[i];
                sum+=A[i];
                proiz*=A[i];
                if (A[i] % 2 == 0) sumChetA += A[i];
            }

            double [,] B = new double [3,4];
            Random rand = new Random();
            //расширю для себя для задания мы знаем размер
            int rows = B.GetUpperBound(0) + 1;    // количество строк
            int columns = B.Length / rows;        // количество столбцов
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    B[i, j] = rand.NextDouble(1, 10);

                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (B[i, j] < min) min = B[i, j];
                    else if (B[i, j] > max) max = B[i, j];
                    sum += B[i, j];
                    proiz *= B[i,j];
                    if (j%2==0) sumNechColB+=B[i, j];// ищем четные тк отсчет столбцов от 0, а для нас от 1
                    Console.Write($"{B[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Максимальный элемент массивов "+max);
            Console.WriteLine("Минимальный элемент массивов " + min);
            Console.WriteLine("Сумма элементов массивов " + sum);
            Console.WriteLine("Произведение элементов массивов " + proiz);
            Console.WriteLine("Сумма четных элементов массива А " + sumChetA);
            Console.WriteLine("Сумма нечетных столбцов массива В " + sumNechColB);
            Console.ReadLine();
            */
            /*
Задание 2
Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
Определить сумму элементов массива, расположенных
между минимальным и максимальным элементами.
            */
            /*
            int[,] arr = new int[5, 5];
            int min = arr[0, 0], nmini = 0, nminj = 0, max = arr[0, 0], nmaxi = 0, nmaxj = 0, sum = 0;
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j]+" ");
                    if (arr[i, j] > max) { max = arr[i, j]; nmaxi = i; nmaxj = j; }
                    else if (arr[i, j] < min) { min = arr[i, j]; nmini = i; nminj = j; }
                }
                Console.WriteLine();
            }
            if (nmini > nmaxi) { int n; n = nmini; nmini = nmaxi; nmaxi = n; }
            else if (nmini == nmaxi && nminj > nmaxj) { int n; n = nmini; nmini = nmaxi; nmaxi = n; }
            for (int i = nmini; i <= nmaxi; i++)
                for (int j = nminj; j <= nmaxj; j++)
                {
                    sum += arr[i, j];
                }
            Console.WriteLine(sum);
            Console.ReadKey();
        */

            /*
    Задание 3
    Пользователь вводит строку с клавиатуры.Необходимо зашифровать данную строку используя шифр Цезаря.
    Из Википедии:
    ДОМАШНЕЕ ЗАДАНИЕ
    1
    Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется
    символом, находящимся на некотором постоянном числе
    позиций левее или правее него в алфавите.Например, 
    в шифре со сдвигом вправо на 3, A была бы заменена на
    D, B станет E, и так далее.
    Подробнее тут: https://en.wikipedia.org/wiki/Caesar_
            cipher.
    Кроме механизма шифровки, реализуйте механизм
    расшифрования.
            */
            /*
                char [] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
                Console.WriteLine("Введите строку для шифровки ");
                string str = Console.ReadLine();
               char[] str2 = str.ToCharArray();
                Console.WriteLine("Введите сдвиг ");
                int sd = int.Parse(Console.ReadLine());
                for (int i = 0; i < str2.Length; i++)
                {                
                    for (int j = 0; j < alfavit.Length; j++)
                    {                    
                        if (str2[i] == alfavit[j]) { if (j + sd > 32) j = j + sd - 34; str2[i] = alfavit[j + sd]; break; }                                   
                    }
                }
                string str1 = string.Concat(str2);

                Console.WriteLine(str1);
                Console.ReadKey();
            */
            /*
        
    Задание 4
    Создайте приложение, которое производит операции
    над матрицами:
    ■ Умножение матрицы на число;
    ■ Сложение матриц;
    ■ Произведение матриц.
            */

            //делаю без запросов, но гибко, чтобы можно было вводить другие матрицы
            //заставили вспонить матрицы в тот раз в этот уже легко :)
            /*
            int n1 = 3, l1 = 3, n2 = 3, l2 = 3;
            double[,] M1 = new double[n1, l1];
            double[,] M2 = new double[n2, l2];
            double[,]sum=new double[n1, l1];
            double[,] ProizNCh = new double[n1, l1];
            double[,] Proiz = new double[n1, l2];
            Random rand = new Random();
           
           
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < l1; j++)
                {
                    M1[i, j] = rand.Next(1, 10);
                    Console.Write($"{M1[i, j]} \t");                    
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    M2[i, j] = rand.Next(1, 10);
                    Console.Write($"{M2[i, j]} \t");
                }
                Console.WriteLine("\n");
            }
            
            if (n1 == n2 && l1 == l2)
                Console.WriteLine("Сумма матриц составляет ");
            {
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < l1; j++)
                    {
                        sum[i, j] = M1[i, j] + M2[i, j];
                        Console.Write($"{sum[i, j]} \t");
                    }
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("Произведение матрицы на число 5 ");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < l1; j++)
                {
                    ProizNCh[i, j] = M1[i, j] * 5;
                    Console.Write($"{ProizNCh[i, j]} \t");
                }
                Console.WriteLine("\n");
            }

            if (n1 == l2) { 
                Console.WriteLine("Произведение матриц составляет ");

            {
                for (int i = 0; i < l2; i++)
                {
                        for (int j = 0; j < n1; j++)
                        {
                            for (int k = 0; k < n1; k++)
                            {
                                Proiz[i, j] += M1[i, k] * M2[k, j];
                            }
                            Console.Write($"{Proiz[i, j]} \t");
                        }
                        Console.WriteLine("\n");
                    }                 
                }
            }
            Console.ReadLine();
            */
            /*
    Задание 5
    Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать
    его результат.Необходимо поддерживать только две
    операции: +и –.
             */
            //я молодец! :) 
            /*
            string[] separator = { "+", "-" };
            string str = Console.ReadLine();
            string[] znach = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            char[] str2 = str.ToCharArray();
            int a1= int.Parse(znach[0]);
            int n = 0;
            
                for (int j = 0; j < znach.Length; j++)
                {
                    for (int i = n; i < str2.Length; i++)
                    {
                        if (str2[i] == '-')
                        {
                            a1 -= Convert.ToInt32(znach[j + 1]);
                            n = i + 1;
                            break;
                        }
                        if (str2[i] == '+')
                        {
                            a1 += Convert.ToInt32(znach[j + 1]);
                            n = i + 1;
                            break;
                        }                        
                    }
                }
            Console.WriteLine(a1);
            Console.ReadKey();
        */

            /*
    Задание 6
    Пользователь с клавиатуры вводит некоторый текст. 
    Приложение должно изменять регистр первой буквы
    каждого предложения на букву в верхнем регистре.
    ДОМАШНЕЕ ЗАДАНИЕ
    2
    Например, если пользователь ввёл: «today is a good
    day for walking.i will try to walk near the sea».
    Результат работы приложения: «Today is a good day
    for walking.I will try to walk near the sea».
            */

            //наверняка можно как-то интереснее и удобнее а не так топорно, но я не придумала. Было бы интересно узнать.
            /*
            Console.WriteLine("Введите текст.");
            string text = Console.ReadLine();            
            char[] t = text.ToCharArray();
            t[0] = char.ToUpper(t[0]);
            for (int i=0; i<t.Length; i++)
            {
                if (t[i] == ' ' && t[i-1] == '.' && i + 1 < t.Length)
                {
                    t[i + 1] = char.ToUpper(t[i + 1]);
                }
                else if (t[i] =='.'&&i+1< t.Length)
                {
                    t[i+1]= char.ToUpper(t[i + 1]);
                }

            }
           Console.WriteLine(t);
           Console.ReadKey();
            */
            /*
    Задание 7
    Создайте приложение, проверяющее текст на недопустимые слова. Если недопустимое слово найдено, оно
    должно быть заменено на набор символов *.По итогам
    работы приложения необходимо показать статистику
    действий.
    Например, если и у нас есть такой текст:
                    To be, or not to be, that is the question,
    Whether 'tis nobler in the mind to suffer
    The slings and arrows of outrageous fortune,
    Or to take arms against a sea of troubles,
    And by opposing end them? To die: to sleep;
                    No more; and by a sleep to say we end
    The heart-ache and the thousand natural shocks
    That flesh is heir to, 'tis a consummation
    Devoutly to be wish'd. To die, to sleep
    Недопустимое слово: die.
    Результат работы:
    To be, or not to be, that is the question,
    Whether 'tis nobler in the mind to suffer
    The slings and arrows of outrageous fortune,
    ДОМАШНЕЕ ЗАДАНИЕ
    3
    Or to take arms against a sea of troubles,
    And by opposing end them? To ***: to sleep;
                    No more; and by a sleep to say we end
    The heart-ache and the thousand natural shocks
    That flesh is heir to, 'tis a consummation
    Devoutly to be wish'd. To ***, to sleep.
    Статистика: 2 замены слова die.

            */
            Console.WriteLine("Введите текст.");
            string text = Console.ReadLine();
            char[] t = text.ToCharArray();
            Console.WriteLine("Введите запрещенное слово");
            string zapr =Console.ReadLine();
            char[] z = text.ToCharArray();
            int shet, s;
            for (int i = 0; i < t.Length; i++)
            {
                shet = 0; s = 0;
                if (t[i] == z[0] && t[i+1] == z[1] && i+z.Length<t.Length)
                {
                    for (int j=2; j<z.Length-2; j++)
                    {
                        if (t[i + j] == z[j])
                        {
                        s++;
                            if (s== z.Length - 2) 
                            { 
                                shet++; 
                            for (int k=i; k<z.Length; k++)
                                {
                                    t[k] = '*';
                                }
                            }
                        }
                        
                    }
                }
 
            }
            Console.WriteLine(t);
            Console.ReadKey();
        }
                
    }
}
