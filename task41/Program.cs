// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите число M: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int M);
if (!isParsed)
{
    Console.WriteLine("error");
    return;
}

int[] userNumbers = new int[M];
Console.WriteLine("Введите числа: ");
for (int i = 0; i < userNumbers.Length; i++)
{
    userNumbers[i]= Convert.ToInt32(Console.ReadLine());
}
Console.Write($"Чисел больше нуля: {CountPositiveNumbers(userNumbers)}");

int CountPositiveNumbers( int[] arr)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j]>0)
        {
            count ++;
        }
    }
    return count;
}
