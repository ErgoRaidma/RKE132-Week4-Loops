Random rnd  = new Random();

int myRandomNum;

int randomSum = 0;
for(int i = 0; i < 2; i++)
{
    myRandomNum = rnd.Next(0, 11); //genereeritakse 0-10 sellisel juhul
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}
Console.WriteLine($"random sum total: {randomSum}");