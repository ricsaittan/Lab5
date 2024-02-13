class Circle
{
    private double Radius;

    //Sets the Radius, but first checks if it can be set by going through the Exception Class
    public void setRadius(string radius)
    {
        try
        {
            new InvalidRadiusException(radius);
            if (Convert.ToDouble(radius) > 0)
            {
                this.Radius = Convert.ToDouble(radius);
            }
        }
        catch (FormatException)
        {
            new InvalidRadiusException(radius);
        }
    }

    //Outputs the radius of the circle.
    public double toString()
    {
        return this.Radius;
    }
}