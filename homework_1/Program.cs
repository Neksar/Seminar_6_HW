// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputNumber(string str) // Проверка на введенный тип данных, число ли это.
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Вы ввели не число");
    }
    return number;
}

int[] InitReadLineArray(int size) // Ввод элементов массива
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"Введите {i + 1} элемент: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}

void PrintArray(int[] arr) // Вывод массива на печать
{
    System.Console.WriteLine(string.Join(", ", arr));
}

int PositiveNumbers(int[] array) // Суммирование колличества положительный чисел массива.
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
        else continue;
    }
    return count;
}

int readLineNumbers = InputNumber("Введите желаемое кол-во элементов массива: ");
int[] numbers = InitReadLineArray(readLineNumbers);
PrintArray(numbers);
int numPositive = PositiveNumbers(numbers);
System.Console.WriteLine($"Колличество чисел больше 0, равно: {numPositive}");