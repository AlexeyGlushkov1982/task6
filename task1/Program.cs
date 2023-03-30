// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"введите {i + 1} - й элемент ");
    }
    return array;
}

int result(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count ++;
        }
    }
    return count;
}

int length = Prompt("ВВедите размер массива -> ");
int[] array = InputArray(length);
Console.WriteLine($"массив - > [{String.Join(",", array)}]");
Console.WriteLine ($"количество чисел больше (0)  - > {result(array)}");