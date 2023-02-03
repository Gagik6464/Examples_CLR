
static void Main()
{
    var p = new Point();
    Console.WriteLine(p.m_x + 1);
}

internal struct Point {
    public Int32 m_x, m_y;
    public Decimal df;

    public Point()
    {
        
    }
}

internal sealed class Rectangle {
    public Point m_topLeft, m_bottomRight;
    public Rectangle() {
// В C# оператор new, использованный для создания экземпляра значимого
// типа, вызывает конструктор для инициализации полей значимого типа
        m_topLeft = new Point();
        m_bottomRight = new Point();
        Activator.CreateInstance(typeof(int));
    }
}
