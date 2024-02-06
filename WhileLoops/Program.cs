
Random rnd = new Random();
int cpuRandom;

    bool loopActive = true; //bool - true/false

    while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a quess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if(userNumber == cpuRandom) 
    {
        Console.WriteLine("Congratulations, you won!");
        // üks võimalus: loopActive = false;
        break;
    }
    else 
    {
        Console.WriteLine("Oops, try again");
    }
}

Console.WriteLine("Have a nice day!");