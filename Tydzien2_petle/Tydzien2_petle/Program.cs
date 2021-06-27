using System;
using System.Collections.Generic;
using System.Text;

namespace Tydzien2_petle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validNumber;
            int i, j;
            //Zadanie 1
            int numberEx1;
            double searchRangeEx1;
            bool isPrimeNumber;
            List<int> primeNumbers = new List<int>();
            for (numberEx1 = 2; numberEx1 <= 100; numberEx1++)
            {
                isPrimeNumber = true;
                searchRangeEx1 = Math.Sqrt(numberEx1);
                for (i = 2; i <= searchRangeEx1; i++)
                {
                    if (numberEx1 % i == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    primeNumbers.Add(numberEx1);
                }
            }

            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Liczbami pierwszymi są:");
            Console.WriteLine(string.Join(", ", primeNumbers));
            Console.WriteLine();

            //Zadanie 2
            int numberEx2 = 0;
            List<int> evenNumbers = new List<int>();

            do
            {
                if (numberEx2 % 2 == 0)
                {
                    evenNumbers.Add(numberEx2);
                }
                numberEx2++;
            } while (numberEx2 <= 1000);

            Console.WriteLine("Zadanie 2");
            Console.WriteLine("Liczbami parzystymi są:");
            Console.WriteLine(string.Join(", ", evenNumbers));
            Console.WriteLine();

            //Zadanie 3
            int numberOfIterations, anotherFibNumber;
            const int FIB_FIRST = 0, FIB_SECOND = 1;
            List<int> fibonacciNumbers = new List<int>();

            Console.Write("Wprowadź liczbę iteracji ciągu Fibonacciego: ");
            validNumber = int.TryParse(Console.ReadLine(), out numberOfIterations);
            if (!validNumber)
                Console.WriteLine("Wprowadzona liczba jest niepoprawna.");
            else
            {
                for (i = 0; i <= numberOfIterations; i++)
                {
                    if (i == 0)
                        fibonacciNumbers.Add(FIB_FIRST);
                    else if (i == 1)
                        fibonacciNumbers.Add(FIB_SECOND);
                    else
                    {
                        anotherFibNumber = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
                        fibonacciNumbers.Add(anotherFibNumber);
                    }
                }
            }

            Console.WriteLine("Zadanie 3");
            Console.WriteLine("Liczbami Fibonacciego są:");
            Console.WriteLine(string.Join(", ", fibonacciNumbers));
            Console.WriteLine();

            //Zadanie 4
            int numberEndPyramid;
            int numberStartPyramid = 1;
            int pyramidIteration = 1;

            Console.Write("Podaj liczbę, do której ma być piramida: ");
            validNumber = int.TryParse(Console.ReadLine(), out numberEndPyramid);
            if (!validNumber)
            {
                Console.WriteLine("Podano niepoprawną liczbę");
            }
            else
            {
                while (numberStartPyramid <= numberEndPyramid)
                {
                    for (i = 0; i < pyramidIteration; i++)
                    {
                        Console.Write(numberStartPyramid + " ");
                        numberStartPyramid++;
                    }
                    if (numberStartPyramid != numberEndPyramid)
                        Console.WriteLine();
                    pyramidIteration++;
                }
            }

            //Zadanie 5
            int numberEx5 = 1;
            while (numberEx5 <= 20)
            {
                Console.WriteLine(Math.Pow(numberEx5, 3d));
                numberEx5++;
            }

            //Zadanie 6
            int numberEx6 = 20;
            int countNumberEx6;
            float sum = 0;
            List<float> resultsEx5 = new List<float>();

            for (i = 0; i <= numberEx6; i++)
            {
                if (i == 0)
                {
                    resultsEx5.Add(0);
                }
                else
                {
                    sum = 0;
                    countNumberEx6 = 1;
                    while (countNumberEx6 <= i)
                    {
                        sum += 1f / countNumberEx6;
                        countNumberEx6++;
                    }
                    resultsEx5.Add(sum);
                }
            }

            Console.WriteLine("Sumowane wartości z zadania 5: ");
            for (i = 0; i < numberEx6; i++)
            {
                Console.WriteLine($"Dla {i} suma wynosi:\t {Math.Round(resultsEx5[i], 2)}");
            }

            //Zadanie 7
            int numberOfRows;
            int gap;
            Console.Write("Wprowadź poziomy diamentu: ");
            validNumber = int.TryParse(Console.ReadLine(), out numberOfRows);
            if (!validNumber)
            {
                Console.WriteLine("Wprowadzono niepoprawną liczbę");
            }
            else
            {
                for (i = 1; i < numberOfRows; i++)
                {
                    for (j = 0; j < numberOfRows - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j < i * 2 - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (i = numberOfRows; i > 0; i--)
                {
                    for (j = 0; j < numberOfRows - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j < i * 2 - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            //Zadanie 8
            Console.WriteLine("Wprowadź ciag znaków");
            StringBuilder characters = new StringBuilder(Console.ReadLine());
            for (i = characters.Length - 1; i >= 0; i--)
            {
                Console.Write(characters[i] + " ");
            }


            //Zadanie 9
            double numberEx9;
            string binary;
            Console.WriteLine("Wprowadź liczbę dziesiętną");
            validNumber = double.TryParse(Console.ReadLine(), out numberEx9);
            if (!validNumber)
            {
                Console.WriteLine("Wprowadzono niepoprawną liczbę");
            }
            else
            {
                long numberEx9ToInt64 = BitConverter.DoubleToInt64Bits(numberEx9);
                binary = Convert.ToString(numberEx9ToInt64, 2);
                Console.WriteLine($"Zamiana: {binary}");
            }

            //Zadanie 10
            int firstNumber, secondNumber;
            bool isNWW = false;
            int nwwNumber = 1;
            Console.Write("Wpisz pierwszą liczbę: ");
            validNumber = int.TryParse(Console.ReadLine(), out firstNumber);
            if (!validNumber)
            {
                Console.WriteLine("Wprowadzono niepoprawną liczbę");
            }
            Console.WriteLine();
            Console.Write("Wpisz drugą liczbę: ");
            validNumber = int.TryParse(Console.ReadLine(), out secondNumber);
            if (!validNumber)
            {
                Console.WriteLine("Wprowadzono niepoprawną liczbę");
            }
            else
            {
                while (!isNWW)
                {
                    if(nwwNumber % firstNumber == 0 && nwwNumber % secondNumber == 0)
                    {
                        Console.WriteLine($"NWW jest liczba {nwwNumber}");
                        isNWW = true;
                    }
                    else
                    {
                        nwwNumber++;
                    }
                }
            }
        }
    }
}
