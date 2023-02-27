const int arrayLen = 10;
int[] array = new int[arrayLen];
for (int i = 0; i < array.Length; i++)
    array[i] = Random.Shared.Next(0, 1_000);
Console.WriteLine(string.Join(",", array)); 
Console.WriteLine(array.Count(x => x % 2 == 0));