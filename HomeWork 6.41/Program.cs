// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите значения, разделяя их запятой: ");
int[] numbers = StringNumbers(Console.ReadLine());
int amount = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0){amount++;}
}
Console.WriteLine($"Положительных значений: {amount}");
int[] StringNumbers(string value)
{
    int count = 1;
    for (int i = 0; i < value.Length; i++)
    {
        if (value[i] == ','){count++;}
    }
    int[] numbers = new int [count];
    int index = 0;
    for (int i = 0; i < value.Length; i++)
    {
        string temp = " ";
        while (value [i] != ',')
        {
            if(i != value.Length - 1)
            {
                temp += value [i].ToString();
                i++;
            }
            else
            {
                temp += value [i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}
