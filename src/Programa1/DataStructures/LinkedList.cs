using System.Collections;

namespace Programa1.DataStructures;

/// <summary>
/// Implementa una lista simplemente enlazada genérica.
/// </summary>
/// <typeparam name="T">Tipo de dato almacenado.</typeparam>
public sealed class LinkedList<T> : IEnumerable<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;

    /// <summary>
    /// Cantidad de elementos almacenados.
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// Agrega un elemento al final de la lista.
    /// </summary>
    public void Add(T value)
    {
        var newNode = new Node<T>(value);

        if (_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail!.Next = newNode;
            _tail = newNode;
        }

        Count++;
    }

    /// <summary>
    /// Permite recorrer los elementos de la lista.
    /// </summary>
    public IEnumerator<T> GetEnumerator()
    {
        var current = _head;

        while (current is not null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}