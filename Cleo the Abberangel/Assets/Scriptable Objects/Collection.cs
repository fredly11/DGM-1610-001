using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collection : ScriptableObject
{

    public List<Object> collection;

    private void OnEnable()
    {
        collection.Clear();
    }

    public void addObject(Object item)
    {
        collection.Add(item);
    }

    public void printObjects()
    {
        foreach (var Object in collection)
        {
            Debug.Log(Object.name);
        }
    }

    public void Empty()
    {
       collection.Clear();
    }
}
