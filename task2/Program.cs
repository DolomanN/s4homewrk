Console.WriteLine("Введите число");
string numbers = Convert.ToString(Console.ReadLine());
char[] chars = numbers.ToCharArray();
int array = numbers.Length;
int sum = 0;
for (int i=0; i < numbers.Length; i++)
{
sum =sum + int.Parse(chars[i].ToString());
}
Console.WriteLine (sum);
