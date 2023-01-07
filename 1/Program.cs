/*
Задайте значения M и N. Напишите программу,
 которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */
//L    R
 
  using System;
class GFG{
static void Even(int M,int N)
{

  if (N < M)
  {
    return;
  }
 
  
  if(N % 2 == 0 )
    Even(M, N - 2);
  else
    Even(M, N - 1);
 
  
  if (N % 2 == 0)
  {
    Console.Write(N + " ");
  }
}
 
static void Odd(int M,int N)
{
  
  if (N < M)
  {
    return;
  }
 
  
  if(N % 2 == 1 )
    Odd(M, N - 2);
  else
    Odd(M, N - 1);
 
  
  if (N % 2 == 1)
  {
    Console.Write(N + " ");
  }
}
}

