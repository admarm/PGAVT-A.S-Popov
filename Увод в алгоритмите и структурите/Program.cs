/* Домашна работа на Андрей Марков №4 от 10В клас
Задача 1: Да се създаде ArrayList с 5 елемента от тип string, да се прочетат и принтират на конзолата.
Да се премахнат първи и трети елемент и списъка да се сортира.

Задача 2: Да се създаде ArrayList от тип int.
Да се премахнат четвърти и пети елемент.
Да се сортира.
*/

using System.Text;
using System.Collections;

ArrayList arrayList_string = new ArrayList(); // Задача 1
ArrayList arrayList_int = new ArrayList(); // Задача 2

Console.OutputEncoding = Encoding.UTF8;

for (int i = 1; i < 6; i++) 
{
    arrayList_string.Add($"Елемент {i}"); // Задача 1
    arrayList_int.Add(i); // Задача 2
}
    // Задача 1
    arrayList_string.RemoveAt(2);    
    arrayList_string.RemoveAt(0);
    arrayList_string.Sort();

    // Задача 2
    arrayList_int.RemoveAt(4);
    arrayList_int.RemoveAt(3);
    arrayList_int.Sort();

Console.WriteLine("Задача 1:\n");
foreach (var element in arrayList_string)
{
    Console.WriteLine(element);
}

Console.WriteLine("\nЗадача 2:\n");
foreach (var element in arrayList_int)
{
    Console.WriteLine(element);
}

Console.ReadKey();