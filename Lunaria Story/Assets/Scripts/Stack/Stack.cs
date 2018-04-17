using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stack<T> {

    [SerializeField]
    private List<T> elements;

    public Stack(T[] array) {
        elements = new List<T>(array);
    }

    public Stack() {
        elements = new List<T>();
    }

    public void Add(T t) {
        elements.Add(t);
    }

    public int Count() {
        return elements.Count;
    }

    public void Remove() {
        if(Count() > 0)
            elements.RemoveAt(Count() - 1);
    }

    public T Top() {
        return elements[Count() - 1];
    }
}
