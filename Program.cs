Random rnd = new Random();
int num = rnd.Next(10);
Console.WriteLine(num);
Console.WriteLine("Guess the number:");
int guessNum = Convert.ToInt32(Console.ReadLine());
if (guessNum == num)
{
    Console.WriteLine("Correct! the number was " + num);
}
else
{
    Console.WriteLine("wrong ");

}
