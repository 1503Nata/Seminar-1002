Console.WriteLine(" Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine();

Console.Write("Введите значение числа M:  ");
int m= Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите значение числа N:  ");
int n= Convert.ToInt32(Console.ReadLine());

{ 
  if ((m<=0) && (n<=0))
  {
   Console.WriteLine("Среди введенных чисел нет натуральных. Задача не имеет решения.");
    return;
  }
}
{
int SumNaturNumber(int m, int n)
{
    if (m == 0) 
    return (n * (n + 1)) / 2;          
    else if (n == 0) return (m * (m + 1)) / 2;       
    if (m == n) return m;                              
    else if (m < n) return n + SumNaturNumber(m, n - 1); //вызов функции SumNaturNumber для значений от m до n-1.
    else return n + SumNaturNumber(m, n + 1);       //если m>n = вызов функции SumNaturNumber для значений от m до n+1.    
}

Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} равна {SumNaturNumber(m, n)}.");
}
