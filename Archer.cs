public class Archer
{
    public int armstype;

    public Archer(int armstype)
    {
        this.armstype = armstype;
    }
    public void verifyarms(int armstype)
    {
        if (armstype == 1)
        {
            Console.WriteLine($"The name of armstype is arrow:{armstype}");
        }
        if (armstype == 2)
        {
            Console.WriteLine($"The name of armstype is sword:{armstype}");
        }
        
    }
    public void checkarmstypevalidity(int armstype)
    {
        if (armstype == 1 || armstype == 2)
        {
            Console.WriteLine("This is valid arms");
        }
        else
        {
            Console.WriteLine("Invalid arms");
        }

    }

}
