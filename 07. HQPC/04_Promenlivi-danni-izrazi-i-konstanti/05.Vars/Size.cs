using System;

public class Size
{
    private double width;
    private double height;

    public Size(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public static Size GetRotatedSize(Size size, double angle)
    {
        double newWidth = Math.Abs(Math.Cos(angle)) * size.width + Math.Abs(Math.Sin(angle)) * size.height;
        double newheight = Math.Abs(Math.Sin(angle)) * size.width + Math.Abs(Math.Cos(angle)) * size.height;
        Size newSize = new Size(newWidth, newheight);
        return newSize;
    }
}
