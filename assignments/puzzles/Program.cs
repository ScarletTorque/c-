static void RandomArray()
{
    int[] array = new int[10];
    int sum = 0;
    int max;
    int lowest;
    for (int i = 0; i < 10; i++)
    {
        Random rng = new Random();
        int num = rng.Next(5, 25);
        array[i] = num;
        sum += num;
    }
    max = array[0];
    lowest = array[0];
    for (int x = 1; x < 10; x++)
    {
        if (max < array[x])
        {
            max = array[x];
        }
        if (lowest > array[x])
        {
            lowest = array[x];
        }
    }
    foreach (var entry in array)
    {
        Console.WriteLine(entry);
    }
    Console.WriteLine($"Sum is {sum}");
    Console.WriteLine($"Max is {max}");
    Console.WriteLine($"Lowest is {lowest}");
}


static int TossCoin()
{
    Console.WriteLine("Tossing a coin");
    Random rng = new Random();
    int side = rng.Next(0, 1);
    if (side == 0)
    {
        Console.WriteLine("Heads");
        return side;
    }else{
        Console.WriteLine("Tails");
        return side;
    }
}


static List<string> Names ()
{
    string[] names = { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
    List<string> longest = new List<string>();
    for (int i = 0; i < names.Length; i++)
    {
        if (names[i].Length>5)
        {
            Console.WriteLine(names[i]);
        }
    }
    return longest;
}


RandomArray();
TossCoin();
Names();
