namespace Programa1.DataStructures;

/// <summary>
/// Representa un nodo de una lista simplemente enlazada.
/// </summary>
/// <typeparam name="T">Tipo de dato almacenado.</typeparam>
internal sealed class Node<T>
{
    public T Value { get; }

    public Node<T>? Next { get; set; }

    public Node(T value)
    {
        Value = value;
        Next = null;
    }
}