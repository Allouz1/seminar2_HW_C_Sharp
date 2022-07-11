Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
int i = 0;
int result = Convert.ToInt32(str[2].ToString());//Не понял как работать с этой функцией
while (i < str.Length)
{
    
    if (result == Convert.ToInt32(str[i].ToString()))
    {
    result = Convert.ToInt32(str[i].ToString());
    }
    i++;
}
 Console.WriteLine("Result: " + result);
 
 // Я понял что здача по стректуре как и первая, не не понимаю как работать с функцией,
 // и если я ставлю число меньше то он выдаёт ошибку.