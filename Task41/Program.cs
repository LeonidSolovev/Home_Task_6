// Задача 41: Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.

int[] array = GetMassiveByUser();
PrintArray(array);
Console.WriteLine($" -> {HowManyPositive(array)}");

int HowManyPositive(int[] arr)
{
    int count =0;
    foreach(int el in arr)
        if (el>0) count++;
    return count;
}

int [] GetMassiveByUser()
{
int n = GetUserInput("Сколько чисел вы хотите ввести? ", "Ошибка ввода!");

int[] arr = new int[n];
for (int i = 0; i<n; i++)
    arr[i] = GetUserInput($"Введите число №{i+1}: ", "Ошибка ввода!");
return arr;
}


static void PrintArray(int [] arr)
{
    Console.Write("[");
    Console.Write(String.Join(", ", arr));
    Console.Write("]");
}

static int GetUserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);
    }

}
