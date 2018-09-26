using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1) Типы
            //a.Определите переменные всех возможных примитивных типов
            //С# и проинициализируйте их.
            sbyte a = 12;
            short b = 893;
            int c = 22478;
            long d = 2143435;
            byte e = 44;
            ushort f = 1237;
            uint g = 3247;
            ulong h = 893499;
            float i = 2.5f;
            double j = 34.234d;
            decimal k = 12.434m;
            //b. Выполните 5 операций явного и 5 неявного приведения.
            decimal number1 = 312432434;
            long number2 = (long)number1;
            int number3 = (int)number2;
            short number4 = (short)number3;
            sbyte number5 = (sbyte)number4;
            ///
            sbyte num = 21;
            short num1 = num;
            int num2 = num1;
            long num3 = num2;
            decimal num4 = num3;

            //c.Выполните упаковку и распаковку значимых типов.
            int value = 123;      // a value type
            object obj = value;     // boxing
            int value2 = (int)obj;   // unboxing
            //d.Продемонстрируйте работу с неявно типизированной
            //переменной.
            var variable = "hello";
            Console.WriteLine("Работа с неявно типизированной переменной: " + variable.GetType());
            //e.Продемонстрируйте пример работы с Nullable переменной.
            int? x = 10;
            if (x.HasValue)
            {
                Console.WriteLine($"Пример работы с Nullable переменной: x is {x.Value}");
            }
            else
            {
                Console.WriteLine("Пример работы с Nullable переменной: x does not have a value");
            }
            //2) Строки
            //a.Объявите строковые литералы.Сравните их.
            string s1 = "abc";
            string s2 = "bca";
            if (String.Compare(s1,s2) < 0)
            {
                Console.WriteLine("Сравнение двух строк в алфавитном порядке: 1 строка предшествует");
            }
            else if (String.Compare(s1,s2) == 0)
            {
                Console.WriteLine("Сравнение двух строк в алфавитном порядке: 1 строка занимает ту же позицию в порядке сортировки");
            }
            else
            {
                Console.WriteLine("Сравнение двух строк в алфавитном порядке: 1 строка следует за 2 строкой");
            }
            //b.Создайте три строки на основе String. Выполните: сцепление,
            //копирование, выделение подстроки, разделение строки на слова,
            //вставки подстроки в заданную позицию, удаление заданной
            //подстроки.
            String str1 = "Самая ранняя из известных звукозаписей британского музыканта Дэвида Боуи продана на аукционе в Великобритании. ";
            String str2 = "Композиция I Never Dreamed ушла с молотка за 39 360 фунтов стерлингов. ";
            String str3 = "Это чуть больше 3,6 млн рублей.";
            Console.WriteLine("сцепление: " + String.Concat(str1,str2));
            Console.WriteLine("копирование: " + String.Copy(str3));
            Console.WriteLine("выделение подстроки: " + str1.Substring(0, 5));
            char[] delims = " ".ToCharArray();
            string[] words = str2.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("разделение строки на слова: ");
            foreach (string word in words)
                Console.Write(word + "/");
            Console.WriteLine("\nвставки подстроки в заданную позицию: " + str1.Insert(6, "(most)"));
            Console.WriteLine("удаление заданной подстроки: " + str1.Remove(0, 5));
            //c.Создайте пустую и null строку.Продемонстрируйте что можно
            //выполнить с такими строками
            string empty = "";
            string nstr = null;
            empty = String.Copy(str1);
            Console.WriteLine("Демонстрация методов пустой строки(копирование): " + empty);
            if(nstr == null)
            {
                Console.WriteLine("nstr является null строкой, поэтому к ней не применяются методы String");
            }
            //d.Создайте строку на основе StringBuilder.Удалите определенные
            //позиции и добавьте новые символы в начало и конец строки.
            StringBuilder strb = new StringBuilder("ABC", 50);
            strb.Append(new char[] { 'D', 'E', 'F' });
            Console.WriteLine("Добавление символов в конец строки: " + strb);
            strb.Remove(0, 3);
            Console.WriteLine("Удаление определенной позиции: " + strb);
            strb.Insert(0, "ABC");
            Console.WriteLine("Добавление символов в начало строки: " + strb);
            //3) Массивы
            //a.Создайте целый двумерный массив и выведите его на консоль в
            //отформатированном виде(матрица).
            int[,] mas = { { 1, 3 }, {1, 2 } };
            for (int ii = 0; ii < 2; ++ii)
            {
                for (int jj = 0; jj < 2; ++jj)
                {
                    Console.Write(mas[ii, jj] + "\t");
                }
                Console.WriteLine("\n");
            }
            //b.Создайте одномерный массив строк. Выведите на консоль его
            //содержимое, длину массива. Поменяйте произвольный элемент
            //(пользователь определяет позицию и значение).
            string[] masstr = new string[4] {"one","two","three","four" };
            Console.WriteLine("MASSIVE: ");
            for(int ii = 0; ii < 4; ii++)
            {
                Console.Write(masstr[ii] + "\t");
            }
            Console.WriteLine("\nTHE LENGTH OF MASSTR IS " + masstr.Length);
            Console.WriteLine("Enter index: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the string: ");
            string replace = Console.ReadLine();
            masstr[number] = replace;
            for (int ii = 0; ii < 4; ii++)
            {
                Console.Write(masstr[ii] + "\t");
            }
            Console.WriteLine("\n");
            //c.Создайте ступечатый(не выровненный) массив вещественных
            //чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов
            //соответственно.Значения массива введите с консоли.
            
            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];

            // Инициализируем ступенчатый массив
            Console.WriteLine("Enter the first raw: ");
            for (int ii = 0; ii < 2; ii++)
            {
                myArr[0][ii] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the second raw: ");
            for (int ii = 0; ii < 3; ii++)
            {
                myArr[1][ii] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the third raw: ");
            for (int ii = 0; ii < 4; ii++)
            {
                myArr[2][ii] = int.Parse(Console.ReadLine());;
            }
            ///////////////////////////////////
            Console.WriteLine("MASSIVE: ");
            for (int ii = 0; ii < 2; ii++)
            {
                Console.Write("{0}\t", myArr[0][ii]);
            }

            Console.WriteLine();
            for (int ii = 0; ii < 3; ii++)
            {
                Console.Write("{0}\t", myArr[1][ii]);
            }

            Console.WriteLine();
            for (int ii = 0; ii < 4; ii++)
            {
                Console.Write("{0}\t", myArr[2][ii]);
            }

            Console.WriteLine();
            //d.Создайте неявно типизированные переменные для хранения
            //массива и строки.
            var array = new object[3];
            var str = "123";
            //4) Кортежи
            //a.Задайте кортеж из 5 элементов с типами int, string, char, string,
            //ulong.
            //b.Сделайте именование его элементов.
            (int first, string second, char third, string fourth, ulong fifth) cortege = (34,"jhkj",'d',"fdgfg",3424);
            //c.Выведите кортеж на консоль целиком и выборочно(1, 3, 4
            //элементы)
            Console.WriteLine("CORTEGE: " + cortege);
            Console.WriteLine("1: " + cortege.first + "\n3: " + cortege.third + "\n4: " + cortege.fourth);
            //d.Выполните распаковку кортежа в переменные.
            int one1;
            string second1;
            char third1;
            string fourth1;
            ulong fifth1;
            (one1, second1, third1, fourth1, fifth1) = cortege;
            //e.Сравните два кортежа.
            var t1 = Tuple.Create(123, "Hello");
            var t2 = Tuple.Create(123, "Hello");
            Console.WriteLine(t1.Equals(t2)); // True
            //5) Создайте локальную функцию в main и вызовите ее. Формальные
            //параметры функции – массив целых и строка. Функция должна вернуть
            //кортеж, содержащий: максимальный и минимальный элементы массива,
            //сумму элементов массива и первую букву строки.
            Tuple<int, int, int, string> Task5(int[] num9, string s)
            {
                int min = num9[0];
                int max = num9[0];

                for (int ii = 1; ii < num9.Length; ii++)
                {
                    if (num9[ii] > max)
                    {
                        max = num9[ii];
                    }
                }

                for (int ii = 1; ii < num9.Length; ii++)
                {
                    if (num9[ii] < min)
                    {
                        min = num9[ii];
                    }
                }

                int sum = max + min;
                string firstLetter = s.Substring(0, 1);

                return Tuple.Create<int, int, int, string>(min, max, sum, firstLetter);
            }
            Console.WriteLine("5 ЗАДАНИЕ: Введите массив");
            int[] num8 = new int[5];
            for (int ii = 0; ii < num8.Length; ii++)
            {
                num8[ii] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите строку ");
            string ss = Console.ReadLine();
            var tup = Task5(num8, ss);
            Console.WriteLine("Минимальный элемент " + tup.Item1 + " Максимальный " + tup.Item2 + " Их сумма " + tup.Item3 + " Первая Буква " + tup.Item4);
        }
    } 
}
