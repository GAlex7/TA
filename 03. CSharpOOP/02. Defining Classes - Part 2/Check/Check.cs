namespace Check
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Space;
    using Matrix;
    using Generic;

    [Version(1, 3)]

    class Check
    {
        static void Main()
        {
            Point3D m = Point3D.StartPoint;
            Point3D n = new Point3D(1, 3, 5);
            Point3D p = new Point3D(2, 4, 6);

            Console.WriteLine("Distance: {0:f2}", Distance.CalcDist(n, p));

            Path path = new Path();
            path.AddPoint(m);
            path.AddPoint(n);
            path.AddPoint(p);

            Console.WriteLine(path);

            PathStorage.Save(path, "Path.txt");

            Console.WriteLine(PathStorage.Load("Path.txt"));

            //Console.WriteLine(PathStorage.Load("noPath.txt"));

            var myMatrix = new Matrix<int>(2, 3);
            Console.WriteLine(string.Join("; ", myMatrix));
            myMatrix[0, 0] = 10;
            var newMatrix = new Matrix<int>(4, 2);
            newMatrix[1, 0] = 7;
            newMatrix = myMatrix * newMatrix;

            //Type type = typeof(Matrix<>);
            //object[] allAttributes =
            //  type.GetCustomAttributes(true);
            //foreach (VersionAttribute attr in allAttributes)
            //{
            //    Console.WriteLine("This class is version {0}.{1} ", type.attr.major, attr.minor);
            //}




        }
    }
}
