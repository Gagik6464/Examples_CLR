using System.Collections;

// Этот вызов передает IEnumerable<String> в Count
var c = Count(new[] { "Grant" });

// Этот метод допускает интерфейс IEnumerable любого ссылочного типа
Int32 Count(IEnumerable<Object> collection)
{
    return 10;
}

public interface IEnumerators<out T> : IEnumerable<T> {
    Boolean MoveNext();
    T Current { get; }
}

public interface IDateTimeEnumerator<T> : IEnumerable
{
    delegate void SomeDelegate<T>(T t);
}