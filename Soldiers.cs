 public class Soldiers
 {
     public int id;
     public string name;
     public int health;
     public bool life;
     public int sword;
     public int calculatedamage;
     public string soldiertype;
     public int arrow;
     public Soldiers(int id,string name,int health,int sword,int calculatedamage,string soldiertype,int arrow,bool life) 
     { 
         this.id = id;
         this.name = name;
         this.health = health;
         this.sword = sword;
         this.calculatedamage=calculatedamage;
         this.soldiertype = soldiertype;
         this.arrow = arrow;
         this.life = life;
     }
     public int verifyhealth(int health)
     {
         if(health >= 0&&health<=100)
         {
             Console.WriteLine($"The heaalth is valid.The value of health is:{health}");

           
         }
         else
         {
             Console.WriteLine("The health is invalid!");
         }
         return health;
     }
     public void presentlife(int health, bool life)
     {
        while(health>0&&life==true)
         {
             health /= 5;
             
         }
         health--;
         Console.WriteLine($"The present life value is:{health}");
              if(health==0&&life==false)
         {
             Console.WriteLine($"The soldire is expire.The present life of a soldier is:{health} and the life condition is:{life}");
         }
     }
     public void reducingsoldiershealth(int sword)
     {
         Console.WriteLine($"The reducing heath of a soldier is:{sword}");
     }
     public void calculatingdamage(int sword)
     {
         int calculatedamage = sword;
         Console.WriteLine($"The damage of health of a soldier is:{calculatedamage}");
     }
     public void verifysoldierhealth(int calculatedamage)
     {
         if(calculatedamage >= 5 &&calculatedamage<=25)
         {
             Console.WriteLine("The condition of soldier is valid.");
         }
         else
         {
             Console.WriteLine("The soldier is invalid!");
         }
     }
     public int calculatecurrentdamage(int calculatedamage)
     {
         int currentdamage=calculatedamage;
         if(currentdamage >= 5)
         {
             currentdamage-=5;
             Console.WriteLine($"The current damage od soldier's health is:{currentdamage}");
         }
         return currentdamage;
     }
     public void verifyarcher(int arrow)
     {
         if(arrow==10)
         {
             Console.WriteLine($"The archer is valid.The number of arrow is:{arrow}");
         }
         else
         {

             Console.WriteLine($"The archer is invalid.The number of arrow is:{arrow}");
         }
     }
     public int calculateamountofdamagebyarcher(int arrow)
     {
         int c = arrow * 2;
         Console.WriteLine($"The damage by archer is:{c}");
         return c;
     }
     public int calculatepresentarrow(int arrow)
     {
         while(arrow>0)
         {
             arrow--;
         }
         return arrow;
     }
     public int getid(int id)
    { 
         return id; 
     }
     public string getname(string name)
     {

     return name; 
     }
     public string verifysoldiertype(string soldiertype)
     {
         if (soldiertype=="archer"||soldiertype=="knight")
         {
             Console.WriteLine($"The sodier type is valid.The soldier type is:{soldiertype}");
         }
         else
         {
             Console.WriteLine("The soldier type is invalid!");
         }
         return soldiertype;
     }
     public int getsword(int sword)
     {

     return sword; 
     }
 }
