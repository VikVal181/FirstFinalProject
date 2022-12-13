

void PrintResult(string[] result) {
    int size_res = result.Length;

    Console.Write("[");

    if (size_res > 0) 
    {
        for (int i = 0; i < size_res; ++i) 
        {
            if (i != 0) {
                Console.Write(", ");
            }

            Console.Write($"\"{result[i]}\"");
        }
    }
    Console.Write("]");
}


void FindShotString(string[] in_str) {
    string[] result = new string[0];
    int in_size = in_str.Length;
    if (in_size > 0)
    {
        for (int i = 0; i < in_size; ++i)
        {
            if (in_str[i].Length < 4)
            {
                int j = result.Length;
                Array.Resize(ref result, j + 1);
                result[j] = in_str[i];
            }
        }
    }

    PrintResult(result);

}

Console.Clear();
Console.WriteLine("Введте число строк:");
int n = Convert.ToInt32(Console.ReadLine());
string[] input_str = new string[n];
if (n > 0)
{
    Console.WriteLine($"Введте {n} строк:");
    for (int i = 0; i < n; ++i)
    {
        input_str[i] = Console.ReadLine();
    }
}
FindShotString(input_str);