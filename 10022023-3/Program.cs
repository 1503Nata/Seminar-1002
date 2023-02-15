Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.WriteLine();
Console.Write("Введите значение числа M:  ");
int m= Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите значение числа N:  ");
int n= Convert.ToInt32(Console.ReadLine());
{ 
  if (((m<0) && (n<0))||((m<0) && (n>0))||((m>0) && (n<0)))
  {
   Console.WriteLine("По условиям задания оба числа должный быть неотрицательными. Повторите попытку.");
    return;
  }
}
int AkkermanFunk(int n,int m)
{ 
    if (n == 0) return m + 1;
    
        if (n != 0 && m == 0) 
        return AkkermanFunk(n - 1, 1);
                  
                  if (n > 0 && m > 0) 
                  return AkkermanFunk(n - 1, AkkermanFunk(n, m - 1));

return AkkermanFunk(n,m);        

}
Console.WriteLine();
Console.WriteLine($"Значение функции Аккермана для аргументов M={m} и N={n} равно {AkkermanFunk(m,n)}"); 
Console.WriteLine();