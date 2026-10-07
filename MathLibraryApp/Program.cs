using MathLibrary;

namespace MathLibraryApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            PointVectorBase pvBase = new Point(1,2,3);
            Vector v = new Vector(5,2,3);
         ;
            Console.WriteLine(   v.Normalize());
        }
    }
}