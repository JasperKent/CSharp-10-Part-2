using System;

namespace Records
{
    class Program
    {
        static void Main()
        {

            PointR r1 = new PointR (1, 2, 3);
            PointR r2 = new PointR (1, 2, 3);

            PointS s1 = new PointS { X = 1, Y = 2, Z = 3 };
            PointS s2 = new PointS { X = 1, Y = 2, Z = 3 };

            PointC c1 = new PointC { X = 1, Y = 2, Z = 3 };
            PointC c2 = new PointC { X = 1, Y = 2, Z = 3 };

            PointRS rs1 = new PointRS(1, 2, 3);
            PointRS rs2 = new PointRS(1, 2, 3);

            Console.WriteLine(rs1);
            Console.WriteLine(s1);

            var point = new PointRS (X: 1.0, Y: 1.0, Z: 1.0);

            var rs3 = rs2 with { Z = 200 };

            var s3 = s2 with { Z = 200 };

            var anon = new { X = 1, Y = 2, Z = 3 };

            var anon2 = anon with { Z = 200 };

            var p3d = new PointR(1, 2, 3);
            var p4d = new Point4D(1, 2, 3, 4);

            Console.WriteLine(p3d);
            Console.WriteLine(p4d);

            double x;
 
            double z;

            (x, double y, z) = p3d;

            Console.WriteLine("Values:");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }
    }
}
