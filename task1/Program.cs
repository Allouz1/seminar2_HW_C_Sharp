Console.WriteLine("Ведите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
int result = Convert.ToInt32(str[1].ToString());
for (int i = 1; i < str.Length; i++ )
{
    if (result == Convert.ToInt32(str[i].ToString()))
    {
    result = Convert.ToInt32(str[i].ToString());
    }
}
Console.WriteLine("Result: " + result);