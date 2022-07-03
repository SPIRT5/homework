
Console.Clear();

/*
Random rnd = new Random();
int number = rnd.Next(10000, 100000);
*/

int getNumber (string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число или не пятизначное число, введите пятизначное число: ";

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result)) 
        {
            if(result > 9999 && result < 100000)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
        }
        else 
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

int number = getNumber("Введите пятизначное число: ");

int firstDigit = number / 10000;
int secondDigit = (number / 1000) % 10;
int thirdDigit = (number / 100) % 10;
int fourthDigit = (number / 10) % 10;
int fifthDigit = number % 10;

if (firstDigit == fifthDigit && secondDigit == fourthDigit)
{
    Console.WriteLine("Сгенерированное число " + number + " является палиндромом");
}
else 
{
    Console.WriteLine("Сгенерированное число " + number + " НЕ является палиндромом");
}