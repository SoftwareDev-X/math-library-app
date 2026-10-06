namespace MathLibrary;

public class Vector : PointVectorBase
{
    public static readonly Vector Zero = new Vector(0);
    public static readonly Vector One = new Vector(1,1,1);
    public static readonly Vector XDir = new Vector(1);
    public static readonly Vector YDir = new Vector(0,1);
    public static readonly Vector ZDir = new Vector(0,0,1);

    public double Length
    {
        get => CalculateDistanceTo(Zero);
    }

    public Vector(double x = 0, double y = 0, double z = 0)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public Vector(Vector sourceVector)
    {
        X = sourceVector.X;
        Y = sourceVector.Y;
        Z = sourceVector.Z;
    }

    public Vector Add(Vector[] addends)
    {
        return CalculateSum(addends).AsVector();
    }
}