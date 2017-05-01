using System;

public class Size
{
    public double width, height;
    public Size(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public static Size GetRotatedSize(
        Size size, double angleOfRotating)
    {
        double width = size.width;
        double height = size.height;
        double cosOfAngle = Math.Cos(angleOfRotating);
        double sinOfAngle = Math.Sin(angleOfRotating);
        return new Size(
                Math.Abs(cosOfAngle) * width +
                Math.Abs(sinOfAngle) * height,
                Math.Abs(sinOfAngle) * width +
                Math.Abs(cosOfAngle) * height
                );
    }
}