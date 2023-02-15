Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
Console.WriteLine();
Console.WriteLine("Введите значение числа N для построения ряда натуральных чисел:  ");
int n= Convert.ToInt32(Console.ReadLine());
{if  (n<=0) 
            {   Console.Write("Вы ввели не натуральное число.Повторите попытку.");
                return;
             }
}
{
void NaturNumber (int n)
{if (n>0)  
            {   
                Console.Write(n + ",");
                 if (n==1) {Console.Write(".");}
                NaturNumber (n-1);
                return;
            }
}        
Console.Write($"Ряд натуральных чисел от {n} до 1: ");

NaturNumber(n);
}
