public class Utility
{
    double knightspresentnumber;
    public void printrandom()
    {
        Random random = new Random();

        double num1=random.NextDouble();
        double num2=random.NextDouble()*2;
        double knightspresentnumber=random.NextDouble();
        if(knightspresentnumber==0)
        {
            Console.WriteLine($"The knight will strike a random number and the value is:{num2}");
        }
        Console.WriteLine($"The value of num1 is:{num1}");
        Console.WriteLine($"The value of num2 is:{num2}");
        Console.WriteLine($"The value of knightspresentnumber is:{knightspresentnumber}");
        
    }
    public void strikeoponent(double knightspresentnumber)
    {
        if( knightspresentnumber==1 )
        {
            Console.WriteLine("Strike oponent successfully!");
        }
        else
        {
            Console.WriteLine("Striking oponent is failed!");
        }
    }
    public void getattackertype(Random random)
    {
        double num3 = random.Next(1, 3);
        if(num3==1.00)
        {
            Console.WriteLine("Hitting the Tristan");
        }
        if (num3 == 2.00)
        {
            Console.WriteLine("Hitting the Morholt");
        }
        else
        {
            Console.WriteLine("Not hit any attackr");
        }
    }
}
