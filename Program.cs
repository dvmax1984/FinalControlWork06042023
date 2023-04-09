/* Программа из имеющегося массива строк формирует новый массив из строк, 
 длина которых меньше, либо равна 3 символам.

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

using static Methods;
Console.WriteLine("\n Вывод из массив строк длиной <= 3 символам, в новый массив и на печать \n");

string[] array = { "Hello", "2", "world", ":-)" };

Console.WriteLine("---[ Исходный массив ]---");
Console.WriteLine(PrintArray(array));

string[] result = GetFromArray(array);

Console.WriteLine("---[  Результат ]---");
Console.WriteLine(PrintArray(result));


