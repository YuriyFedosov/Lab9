using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Смоделируйте работу простого калькулятора. 
             * Программа должна запрашивать 2 числа, а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). 
             * После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.*/

            //Определяем переменные
            bool trueFlag = true; //флаг для циклов ввода данных
            int firstNumb=0, secondNumb=0; int totResult; 
            double totResultDiv;
            Console.WriteLine("Вы используете программу калькулятор.");
          
            while(trueFlag) //Ввод первого значения с проверкой на корректность
            {
            Console.Write("Введите первое целое число для подсчета. Х = ");
            try
            {
            firstNumb = Convert.ToInt32(Console.ReadLine()); //Считываем число 1
            trueFlag = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            }

            trueFlag = true;//возврат флага
            while (trueFlag) //Ввод второго значения с проверкой на корректность
            {
                Console.Write("Введите второе целое число для подсчета. Y = ");
                try
                {
                    secondNumb = Convert.ToInt32(Console.ReadLine()); //Считываем число 2
                    trueFlag = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            trueFlag = true; //возврат флага
            
            while (trueFlag) //Блок операций, с проверкой на корректность
            { 
            Console.Write("\nВыберите операцию над числами:\n1 - Сложение\n2 - Вычитание\n3 - Умножение\n4 - Деление\nВведите необходимое действие - ");
            
                try
                {
                    int operatChoise = Convert.ToInt32(Console.ReadLine()); //Считываем параметр кода операции
                    if (operatChoise >=1 && operatChoise <= 4) //Выполнение операции или возврат
                    {
                    switch (operatChoise)
                        {
                        case 1: totResult= firstNumb + secondNumb; Console.WriteLine("Результат сложения = {0}", totResult); trueFlag = false; break;
                        case 2: totResult = firstNumb - secondNumb;  Console.WriteLine("Результат вычитания = {0}", totResult); trueFlag = false; break;
                        case 3: totResult = firstNumb * secondNumb;  Console.WriteLine("Результат умножения = {0}", totResult); trueFlag = false; break;
                        case 4: // Идет С проверкой на деление на нуль
                                {
                                    totResultDiv = Convert.ToDouble(firstNumb) / Convert.ToDouble(secondNumb);
                                    if (double.IsInfinity(totResultDiv))
                                    {
                                        Console.WriteLine("Деление на нуль !!! Выберите другую операцию...");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Результат деления = {0}", totResultDiv);
                                        trueFlag = false;
                                        break;
                                    }
                                }

                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("Выбрана несуществующая операция...\n");
                    }
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }

            Console.ReadKey();
        }
    }
}
