class program
{
    public static void Main(string[] args)
    {
        Archer a1 = new Archer(1);
        Archer a2 = new Archer(2);
        Archer a3 = new Archer(3);
        a1.verifyarms(1);
        a2.verifyarms(2);
        a3.verifyarms(3);
        a1.checkarmstypevalidity(1);
        a2.checkarmstypevalidity(2);
        a3.checkarmstypevalidity(3);
        Knight k1 = new Knight(1,100,5,2,"arrow");
        Knight k2 = new Knight(2,50,60,40,"sword");
        Knight k3 = new Knight(3,10,20,30,"knife");
        Console.WriteLine(k1.calculatepresenthealthdamagebyarrow(5));
        Console.WriteLine(k2.calculatepresenthealthdamagebyarrow(60));
        Console.WriteLine(k3.calculatepresenthealthdamagebyarrow(40));
        Console.WriteLine(k1.calculatepresenthealthdamagebyasword(2));
        Console.WriteLine(k2.calculatepresenthealthdamagebyasword(40));
        Console.WriteLine(k3.calculatepresenthealthdamagebyasword(30));
       k1.getarmstype(1);
        k2.getarmstype(2);
        k3.getarmstype(3);
        Console.WriteLine(k1.verifyarms("arrow"));
        Console.WriteLine(k2.verifyarms("sword"));
        Console.WriteLine(k3.verifyarms("knife"));
        Console.WriteLine(k1.gethealth(100));
        Console.WriteLine(k2.gethealth(50));
        Console.WriteLine(k3.gethealth(10));
        Soldiers s1 = new Soldiers(1,"A",50,20,20,"archer",10,true);
        Soldiers s2 = new Soldiers(2,"B",0,10,10,"knight",7,false);
        Soldiers s3 = new Soldiers(3,"C",30,48,48,"military",-4,true);
        Console.WriteLine(s1.verifyhealth(50));
       s1.presentlife(50,true);
        s1.reducingsoldiershealth(50);
        s1.calculatingdamage(50);
        s1.verifysoldierhealth(50);
        Console.WriteLine(s1.calculatecurrentdamage(20));
        s1.verifyarcher(10);
        Console.WriteLine(s1.calculateamountofdamagebyarcher(10));
        Console.WriteLine(s1.calculatepresentarrow(10));
        Console.WriteLine(s1.getid(1));
        Console.WriteLine(s1.getname("A"));
        Console.WriteLine(s1.verifysoldiertype("archer"));
        Console.WriteLine(s1.getsword(20));
        Console.WriteLine(s2.verifyhealth(0));
        s2.presentlife(0,false);
        s2.reducingsoldiershealth(10);
        s2.calculatingdamage(10);
        s2.verifysoldierhealth(10);
        Console.WriteLine(s2.calculatecurrentdamage(10));
        s2.verifyarcher(7);
        Console.WriteLine(s2.calculateamountofdamagebyarcher(7));
       
        Console.WriteLine(s2.calculatepresentarrow(7));
        Console.WriteLine(s2.getid(2));
        Console.WriteLine(s2.getname("B"));
        Console.WriteLine(s2.verifysoldiertype("knight"));
        Console.WriteLine(s2.getsword(10));
        Console.WriteLine(s3.verifyhealth(30));
        s3.presentlife(30,true);
        s3.reducingsoldiershealth(48);
        s3.verifysoldierhealth(48);
        Console.WriteLine(s3.calculatecurrentdamage(48));
        s3.verifyarcher(-4);
        Console.WriteLine(s3.calculateamountofdamagebyarcher(-4));
        Console.WriteLine(s3.calculatepresentarrow(-4));
        Console.WriteLine(s3.getid(3));
        Console.WriteLine(s3.getname("C"));
        Console.WriteLine(s3.verifysoldiertype("military"));
        Console.WriteLine(s3.getsword(48));
        Utility utility = new Utility();
        utility.printrandom();
        utility.strikeoponent(1);
        Random random = new Random(); 
        utility.getattackertype(random);
    }
