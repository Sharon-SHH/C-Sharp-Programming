// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input a number:");

int input = Convert.ToInt32(Console.ReadLine());
while ( input != 1)
{
    if (input % 2 == 0 )
    {
        input /= 2;
    }
    else
    {
        input = input * 3 + 1;
    }
    Console.WriteLine(input);
}
Console.WriteLine("Finished! The result is " + input);

