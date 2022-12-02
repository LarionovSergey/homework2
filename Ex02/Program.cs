Random random = new Random();  
int number = 0;
number = random.Next(1,9999);
Console.WriteLine(number);
string stringNumber = Convert.ToString(number);
if (number > 100)
Console.WriteLine("Третье число: " + stringNumber[2]);
if (number < 100)
Console.WriteLine("Третьей цифры нет");