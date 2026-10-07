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

    public Vector Add(params Vector[] addends)
    {
        return CalculateSum(addends).AsVector();
    }

    public Vector Subtract(params Vector[] subtrahends)
    {
        var result = new Vector(this);
        foreach (var subtrahend in subtrahends)
        {
            result.X -= subtrahend.X;
            result.Y -= subtrahend.Y;
            result.Z -= subtrahend.Z;
        }

        return result;
    }

    public Vector MultiplyScalar(double scalarFactor)
    {
        return new Vector(X * scalarFactor, 
            Y * scalarFactor, 
            Z * scalarFactor);
    }

    public Vector CrossProduct(Vector b)
    {
        return new Vector(
            Y * b.Z - Z * b.Y,
            -(X * b.Z - Z * b.X),
            X * b.Y - Y * b.X);
    }

    public double DotProduct(Vector b)
    {
        return X * b.X + Y * b.Y + Z * b.Z;
    }

    public Vector Normalize()
    {
        return new Vector(X / Length, Y / Length, Z / Length);
    }

    public bool AreCollinear(Vector b, double tolerance = Tolerance)
    {
        return Math.Abs(DotProduct(b)) < tolerance;
    }
    
}