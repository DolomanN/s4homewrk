int[] array = new int [8];
Random r = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(10);
    Console.WriteLine(array[i]);
} 
