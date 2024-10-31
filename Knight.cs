public class Knight
{
    public int arms;

    public int health;
    public int arrow;
    public int sword;
    public string armstype;
    
    public Knight(int arms,  int health, int arrow, int sword,string armstype)
    {
        this.arms = arms;

        this.health = health;
        this.arrow = arrow;
        this.sword = sword;
        this.armstype = armstype;
        
    }
    public int calculatepresenthealthdamagebyarrow(int arrow)
    {
        return arrow;
    }
    public int calculatepresenthealthdamagebyasword(int sword)
    {
        return sword;
    }
    public void getarmstype(int arms)

    {
        if (arms == 1)
        {
            Console.WriteLine("The arms type is arrow.");
        }
        if (arms == 2)
        {
            Console.WriteLine("The arms type is sword.");
        }
        else
        {
            Console.WriteLine("Invalid arms!");
        }
    }
    public string verifyarms(string armstype)
    {
        if(armstype=="arrow"||armstype=="sword")
        {
            Console.WriteLine("This are valid arms");
        }
        else
        {
            Console.WriteLine("Invalid arms!");
        }
        return armstype;
    }
    public int gethealth(int health)
    {

    return health; 
    }    
}
