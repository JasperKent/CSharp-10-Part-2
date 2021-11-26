using System;

namespace Records
{
    public class PointC
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double Z { get; init; }
    }

    public struct PointS
    {

        public double X { get; init; }
        public double Y { get; init; }
        public double Z { get; init; }
    }

    public record class PointR(double X, double Y, double Z)
    {
        public sealed override string ToString()
        {
            return "This is the base class.";
        }
    }

    public readonly record struct PointRS(double X, double Y, double Z);

    public record Point4D : PointR
    {
        public double CT { get; init; }

        public Point4D(double X, double Y, double Z, double ct) 
            : base(X, Y, Z)
        {
            CT = ct;
        }
    }
}
