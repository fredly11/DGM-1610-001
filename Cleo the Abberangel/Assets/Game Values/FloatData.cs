using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;
    public float startValue;
    public float maxValue;

    private void OnEnable()
    {
        value = startValue;
    }

    public void addValue(float valueToAdd)
    {
        value += valueToAdd;
        if (value > maxValue)
        {
            setValue(maxValue);
        }
    }

    public void subtractValue(float valueToSubtract)
    {
        value -= valueToSubtract;
    }

    public void setValue(float valueToSet)
    {
        value = valueToSet;
    }
}
