namespace MathLibrary;

public class Point : PointVectorBase
{
    public static readonly Point Origin = new Point();

    public Point(double x = 0, double y = 0, double z = 0)
    {
        X = x;
        Y = y;
        Z = z;
    }
    
    public Point(Point sourcePoint)
    {
        X = sourcePoint.X;
        Y = sourcePoint.Y;
        Z = sourcePoint.Z;
    }

    public double DistanceTo(Point endPoint)
    {
        return CalculateDistanceTo(endPoint);
    }

    public Point Add(params Vector[] addends)
    {
        return CalculateSum(addends).AsPoint();
    }


}