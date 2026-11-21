using Xunit;
using DoubleLinkedList = Programa1.DataStructures.LinkedList<double>;
using StringLinkedList = Programa1.DataStructures.LinkedList<string>;

namespace Programa1.Tests;

/// <summary>
/// Pruebas unitarias de la lista enlazada genérica.
/// </summary>
public class LinkedListTests
{
    [Fact]
    public void NewList_ShouldBeEmpty()
    {
        var list = new DoubleLinkedList();

        Assert.Equal(0, list.Count);
        Assert.Empty(list);
    }

    [Fact]
    public void Add_ShouldIncreaseCount()
    {
        var list = new DoubleLinkedList();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        Assert.Equal(3, list.Count);
    }

    [Fact]
    public void Add_ShouldPreserveInsertionOrder()
    {
        var list = new DoubleLinkedList();

        list.Add(10);
        list.Add(20);
        list.Add(30);

        Assert.Equal(
            new double[] { 10, 20, 30 },
            list.ToArray());
    }

    [Fact]
    public void Add_ShouldAllowDuplicateValues()
    {
        var list = new DoubleLinkedList();

        list.Add(5);
        list.Add(5);
        list.Add(5);

        Assert.Equal(3, list.Count);

        Assert.Equal(
            new double[] { 5, 5, 5 },
            list.ToArray());
    }

    [Fact]
    public void Add_ShouldSupportNegativeAndDecimalValues()
    {
        var list = new DoubleLinkedList();

        list.Add(-10);
        list.Add(2.5);
        list.Add(-3.75);

        Assert.Equal(
            new double[] { -10, 2.5, -3.75 },
            list.ToArray());
    }

    [Fact]
    public void LinkedList_ShouldSupportGenericTypes()
    {
        var list = new StringLinkedList();

        list.Add("PSP");
        list.Add("Programa1");

        Assert.Equal(2, list.Count);

        Assert.Equal(
            new string[] { "PSP", "Programa1" },
            list.ToArray());
    }
}