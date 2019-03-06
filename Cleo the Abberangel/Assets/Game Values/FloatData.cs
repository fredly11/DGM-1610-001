using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    [SerializeField] private float value;
    [SerializeField] private float startValue;
    [SerializeField] private float maxValue;

    public float Value
    {
        get { return value;}
        set { this.value = value;}
    }
    public float StartValue
    {
        get { return startValue;}
        set { this.startValue = value;}
    }
    public float MaxValue
    {
        get { return maxValue;}
        set { this.maxValue = value;}
    }

    private void OnEnable()
    {
        value = startValue;
    }

    public void addValue(float valueToAdd)
    {
        value += valueToAdd;
        if (value > maxValue)
        {
            Value = maxValue;
        }
    }

    public void addValue(FloatData floatObj)
    {
        Value += floatObj.Value;
    }

}
