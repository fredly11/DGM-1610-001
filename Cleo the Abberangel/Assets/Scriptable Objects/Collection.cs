using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : ScriptableObject
{

    public List<Object> collection;


    void addObject(Object item)
    {
        collection.Add(item);
    }
}
