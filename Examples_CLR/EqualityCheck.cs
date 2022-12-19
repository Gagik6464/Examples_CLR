namespace Test_Examples_CLR;

internal class EqualityCheck : IComparable<EqualityCheck>, IComparable, IEquatable<EqualityCheck>
{
    public EqualityCheck(string name, int age)
    {
        Name = name;
        Age = age;
    }

    private string Name { get; }
    private int Age { get; }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }

    int IComparable.CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 0;
        return obj.GetType() != GetType() ? 0 : CompareTo((EqualityCheck) obj);
    }

    public static bool operator ==(EqualityCheck obj1, EqualityCheck obj2)
    {
        return Equals(obj1, obj2);
    }
    
    public static bool operator >(EqualityCheck obj1, EqualityCheck obj2)
    {
        return obj1.CompareTo(obj2) > 0;
    }

    public static bool operator <(EqualityCheck obj1, EqualityCheck obj2)
    {
        return obj1.CompareTo(obj2) > 0;
    }
    
    public static bool operator >=(EqualityCheck obj1, EqualityCheck obj2)
    {
        return obj1.CompareTo(obj2) is 0 or > 0;
    }

    public static bool operator <=(EqualityCheck obj1, EqualityCheck obj2)
    {
        return obj1.CompareTo(obj2) is 0 or < 0;
    }

    public static bool operator !=(EqualityCheck obj1, EqualityCheck obj2)
    {
        return !Equals(obj1, obj2);
    }

    public int CompareTo(EqualityCheck? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);

        return nameComparison != 0 ? nameComparison : Age.CompareTo(other.Age);
    }

    public bool Equals(EqualityCheck? other)
    {
        return CompareTo(other) == 0;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        return obj.GetType() == GetType() && Equals((EqualityCheck) obj);
    }
}