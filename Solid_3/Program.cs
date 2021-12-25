using System;

abstract class Figure
{
    public abstract int GetArea();
}
class Rectangle : Figure
{
    public int Width { get; set; }
    public int Height { get; set; }
    public override int GetArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!! Тепер створено інтерфейс!
class Square : Figure
{
    public int Width { get; set; }

    public override int GetArea()
    {
        return Width * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figure rect = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine(rect.GetArea());
        //Відповідь 100? Що не так??? Було порушено принцип підстановки Барбари Лісков.
        Console.ReadKey();
    }
}

