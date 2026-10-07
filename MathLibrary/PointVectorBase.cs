namespace MathLibrary;

public class PointVectorBase
{
    public const double Tolerance =  0.0000000001;
    public double X { get;set; }
    public double Y { get;set;}
    public double Z { get;set;}

    protected PointVectorBase(double x = 0, double y = 0, double z = 0)
    {
        X = x;
        Y = y;
        Z = z;
    }

    protected PointVectorBase(PointVectorBase sourcePvBase)
    {
        X = sourcePvBase.X;
        Y = sourcePvBase.Y;
        Z = sourcePvBase.Z;
    }

    protected double CalculateDistanceTo(PointVectorBase endPvBase)
    {
        return Math.Sqrt(Math.Pow(endPvBase.X - X, 2) 
                         + Math.Pow(endPvBase.Y - Y, 2) 
                         + Math.Pow(endPvBase.Z-Z,2));
    }

    protected PointVectorBase CalculateSum(params Vector[] addends)
    {
        var result = new PointVectorBase(this);
        foreach (var addend in addends)
        {
            result.X += addend.X;
            result.Y += addend.Y;
            result.Z += addend.Z;
        }

        return result;
    }

    public Point AsPoint()
    {
        return new Point(X,Y,Z);
    }

    public Vector AsVector()
    {
        return new Vector(X,Y,Z);
    }

    public override string ToString()
    {
        return "X: " + X + " Y: " + Y + " Z: " + Z ;
    }
}