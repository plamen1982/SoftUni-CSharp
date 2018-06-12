using System;
using System.Collections.Generic;
using System.Text;


/*Create class Circle with properties Center and Radius. 
 * The center is a point with coordinates X and Y (make a class Point). 
 * Write a method bool Intersect(Circle c1, Circle c2) that tells whether the two 
 * given circles intersect or not. Write a program that tells if two circles intersect.
 * The input lines will be in format: {X} {Y} {Radius}. Print as output “Yes” or “No”.
*/
class Circle
{
    public Point Center { get; set; }
    public double Radius { get; set; }

    public Circle(Point p1, double Radius)
    {
        this.Center = p1;
        this.Radius = Radius;
    }

    public static bool Intersect(Circle c1, Circle c2)
    {
        double distance = Math.Sqrt((c1.Center.X - c2.Center.X)*(c1.Center.X - c2.Center.X) + (c1.Center.X - c2.Center.X) * (c1.Center.Y - c2.Center.Y));
        
        bool isIntersect;

        if (c1.Radius + c2.Radius >= distance)
        {
            return isIntersect = true;
        }
        else
        {
            return isIntersect = false;
        }
    }
}

