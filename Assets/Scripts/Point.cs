using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Point
{
    public int x;
    public int y;

    public Point(int newX, int newY)
    {
        x = newX;
        y = newY;
    }

    public void Multiply(int value)
    {
        x *= value;
        y *= value;
    }

    public void Add(Point point)
    {
        x += point.x;
        y += point.y;
    }

    public bool Equals(Point point)
        => x == point.x && y == point.y;

    public Vector2 ToVector()
        => new Vector2(x, y);
    /*
     //тоже самое, что написано выше
    public Vector2 ToVector()
    {
       return new Vector2(x, y);
    }
    */
    public static Point FromVector(Vector2 vector)
         => new Point((int)vector.x, (int)vector.y);
    public static Point FromVector(Vector3 vector)
        => new Point((int)vector.x, (int)vector.y);
    public static Point Multiply(Point point, int value)
        => new Point(newX: point.x * value, newY: point.y * value);
    public static Point Add(Point point1, Point point2)
        => new Point(newX: point1.x + point2.x, newY: point1.y + point2.y);
    public static Point Clone(Point point)
        => new Point(point.x, point.y);
    public static Point zero => new(newX: 0, newY: 0);
    public static Point up => new(newX: 0, newY: 1);
    public static Point down => new(newX: 0, newY: -1);
    public static Point left => new(newX: -1, newY: 0);
    public static Point right => new(newX: 1, newY: 0);
}
