class InvalidRadiusException
{
    //Class that takes the radius and checks the value of the radius.
    //Checks if it's less that or equal to zero
    //Cehcks if the input is a double and not a string/char
    public InvalidRadiusException(string radius)
    {
        double temp;
        try
        {
            temp = Convert.ToDouble(radius);
        }
        catch (FormatException)
        {
            Console.WriteLine($"{radius} is not a number");
            return;
        }
        if (temp <= 0)
        {
            Console.WriteLine($"{radius} is less than or equal to 0");
            return;
        }
    }
    //No argument constructor that returns nothing.
    public InvalidRadiusException()
    {
        return;
    }
}