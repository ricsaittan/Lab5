namespace Lab5
{
    internal class Program
    {
        //Sets the Positive radius
        static void PositiveCirlce()
        {
            Circle Circle1 = new Circle();
            Circle1.setRadius("1"); 
            Console.WriteLine(Circle1.toString());         
        }
        //Sets the Negative radius
        static void NegativeCirlce()
        {
            Circle Circle1 = new Circle();
            Circle1.setRadius("-1");      
        }
        //Sets the Zero radius
        static void ZeroCirlce()
        {
            Circle Circle1 = new Circle();
            Circle1.setRadius("0");        
        }
        //Sets an Invalid radius
        static void InvalidCirlce()
        {
            Circle Circle1 = new Circle();
            Circle1.setRadius("e");      
        }
        //Main Program that stars.
        static void Main(string[] arg)
        {
            PositiveCirlce();
            NegativeCirlce();
            ZeroCirlce();
            InvalidCirlce();
        }
    }
}