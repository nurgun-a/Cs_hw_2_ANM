using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cs_hw_2_ANM
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Домашнее задание № 2";
            bool key_1 = true;
            do
            {
                Clear();
                WriteLine(@"        Домашнее задание № 2;
        1.	Изменить введенную строку пользователем на противоположный ( верхний или нижний ) регистр.
        2.	Выполнить реверс введенного пользователем числа. 1234    4321
        3.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; 
    каждое число должно выводиться на новой строке; 
    при этом каждое число должно выводиться количество раз, равное его значению (например, число 3 выводится 3 раза). 
    Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
    3 3 3
    4 4 4 4
    5 5 5 5 5
    6 6 6 6 6 6
    7 7 7 7 7 7 7 ");
                WriteLine();
                Write("    Выберте номер задания (или \"0\" чтобы выйти):");
                String key = ReadLine();
                switch (key)
                {
                    case "1":
                        {
                            WriteLine("Введите строку: ");
                            String stmp = ReadLine();
                            String stmp2 = new string(stmp.Select(ch => char.IsLower(ch) ? char.ToUpper(ch) : char.ToLower(ch)).ToArray());
                            WriteLine("----------------------------------------------------------");
                            WriteLine(stmp2);
                        }
                        break;
                    case "2":
                        {
                            WriteLine("Введите число : ");
                            string str = ReadLine();
                            char[] strR = str.ToCharArray();
                            Array.Reverse(strR);
                            str = new string(strR);
                            WriteLine(str);
                        }
                        break;
                    case "3":
                        {
                            Write("Введите первое число: ");
                            int A = int.Parse(ReadLine());
                            Write("Введите второе число: ");
                            int B = int.Parse(ReadLine());

                            for (int i = (A < B ? A : B); i <= (A < B ? B : A); i++)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    Write($"{i}  ");
                                }
                                WriteLine();
                            }
                        }
                        break;
                    case "0":
                        {
                            key_1 = false;
                        }
                        break;
                    default:
                        WriteLine();
                        WriteLine("\tОшибка ввода");
                        break;
                }
                if (key != "0") Write("\tНажмите \"Enter\" чтобы продолжить ... ");
                if (key != "0") ReadLine();
            } while (key_1);           
        }
    }
}
