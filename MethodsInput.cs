public static class MethodsInput
{
    public static int GetNumber(string s)
    {
        Console.Write(s);
        int result;

        while (true)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out result))
                break;
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Допускается ввод только чисел!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(s);
                Console.ResetColor();
            }
        }
        return result;
    }

    public static string[] GetString(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите текст в строку №{i + 1}: ");
            array[i] = Console.ReadLine();
        }
        return array;
    }
}