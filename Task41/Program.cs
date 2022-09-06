/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/
Console.Write($"Введи число М(количество чисел): ");
int m = int.Parse(Console.ReadLine());
int[] Num = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    Num[i] = int.Parse(Console.ReadLine());
  }
}


int Comparison(int[] Num)
{
  int count = 0;
  for (int i = 0; i < Num.Length; i++)
  {
    if(Num[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(Num)} ");

