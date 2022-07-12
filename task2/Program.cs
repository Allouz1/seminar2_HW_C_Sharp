Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
int i = 0;
// int result = Convert.ToInt32(str[2].ToString());
if (number > 99)
{
    int result = Convert.ToInt32(str[2].ToString());
    
    if (result == Convert.ToInt32(str[i].ToString()))
        {
            result = Convert.ToInt32(str[i].ToString());
            
        }
    Console.WriteLine("Result: " + result);
}
else
{
    Console.WriteLine("Нет третьей цифры");
}
 
 // Я понял, что задача по структуре как и первая, но не понимаю как работать с функцией,
 // и если я ставлю число меньше, то он выдаёт ошибку.