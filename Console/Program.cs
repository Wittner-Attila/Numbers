int[] table = TableGame();

string tableString = "";
table.ToList().ForEach(t => tableString += t);

Console.WriteLine(tableString);


int[] TableGame()
{
    int[,] table = new int[3, 3] ;

    for (int i = 0; i < 3; i++)
    {
        int[] line = ReadListFromConsole();
        for (int j = 0; j < 3; j++)
        {
            table[i,j] = line[j];
        }
    }

    if (!IsTableCorrect(table)) return [-1];
    return [table[0, 0], table[0, 2], table[2, 0], table[2, 2],];
}


bool IsTableCorrect(int[,] array)
{
    for (int i = 0;i < 3; i++)
    {
        if (array[i,0] + array[i,2] != array[i,1]) return false;
        if (array[0, i] + array[2, i] != array[1, i]) return false;
    }
    return true;
}

void WriteArrayToConsole(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}

static int[] ReadListFromConsole()
{
    List<int> value;
    do
    {
        value = new List<int>();
        Console.WriteLine($"Enter a list of 3 numbers(1,2,3)");
        string input = Console.ReadLine();
        foreach (var item in input.Split(','))
        {
            if (String.IsNullOrEmpty(item)) continue;
            int val;
            int.TryParse(item, out val);
            value.Add(val);
        }
        ;
    } while (value.Count != 3);
    return value.ToArray();
}
