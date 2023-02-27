const int arrayLen = 4;
int[] array = new int[arrayLen];
for (int i = 0; i < array.Length; i++)
    array[i] = Random.Shared.Next(-99, 100);
Console.WriteLine(string.Join(",", array));
int sum = array
    .Where((_, index) => index % 2 == 1)
    .Sum();
Console.WriteLine(sum);