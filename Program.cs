/* Программу, которая из имеющегося массива строк формирует новый массив из строк, 
 длина которых меньше, либо равна 3 символам.

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

string[] array = {"Hello", "2", "world", ":-)"};
string[] result = new string[4];

int n = 0;

for (int m=0; m < array.Length; m++)
{
    if (array[m].Length <= 3)
    {
        result[n] = array[m].ToString();
        n =+1;
        //Console.WriteLine(array[m].ToString());
    }
}

for (int i=0; i < result.Length-1; i++)
{
    Console.WriteLine(result[i].ToString());

}
