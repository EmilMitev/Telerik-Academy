using System;
using System.Globalization;
using System.Threading;

/*  Problem 4. Rectangles
    Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */
public class Rectangles
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter width:");
        float width = float.Parse(Console.ReadLine().Replace(',', '.'));

        Console.Write("Enter height:");
        float height = float.Parse(Console.ReadLine().Replace(',', '.'));

        float area = width * height;
        float perimeter = 2 * (width + height);

        Console.WriteLine("Rectangle’s perimeter is: " + perimeter);
        Console.WriteLine("Rectangle’s area is: " + area);
    }
}