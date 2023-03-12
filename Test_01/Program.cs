// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int quantity;
Console.WriteLine("Введите количество строк, которое Вы хотите ввести:");
quantity = int.Parse(Console.ReadLine()!);

string[] strings = new string[quantity];
Console.WriteLine("Введите строки через 'Enter'");
for (int i = 0; i < strings.Length; i++)
    strings[i] = Console.ReadLine()!;

int count=0;
int requiredLength=3;
for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length<=requiredLength) count++;
}
string [] shortsStrings = new string [count];
for (int i = 0, j=0; i < strings.Length; i++)
{
    if (strings[i].Length<=requiredLength) 
    {
        shortsStrings[j]=strings[i];
        j++;
    }
}
Console.WriteLine();
Console.WriteLine($"Строки длина, которых меньше или равна {requiredLength}:");
for (int i = 0; i < shortsStrings.Length; i++) Console.WriteLine($"{shortsStrings[i]}\t");

