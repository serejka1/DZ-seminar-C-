Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int negativeNumber = -number;
    while (negativeNumber <= number)
    {it
        Console.Write(negativeNumber + ", ");
        negativeNumber++;
    }
}