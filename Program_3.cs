int getNumber (string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число, введите корректное число, больше нуля.";

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result)) 
        {
            if(result <= 0)
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
            else
            {
                break;
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

int number = getNumber("Введите число больше нуля: ");
int numberCub = 1;

for (int i = 1; i <= number; i++) {

    numberCub = i*i*i;
    Console.Write(numberCub + ", ");
    
}

Console.WriteLine("");