const int arrayLen = 4;
double[] array = new double[arrayLen];
for (int i = 0; i < array.Length; i++)
    array[i] = Random.Shared.NextDouble() * 100;
Console.WriteLine(string.Join(" : ", array));
double delta = array.Max() - array.Min();
Console.WriteLine(delta);