using System;
using StrangeGame;
using UnityEngine;

[Serializable]
public class FloatReference
{
    [SerializeField] private bool useConstants;
    [SerializeField] private float constantValue;

    [SerializeField] private FloatVariable variable;

    public FloatReference()
    {
        useConstants = true;
    }

    public FloatReference(float value)
    {
        useConstants = true;
        constantValue = value;
    }

    public float Value => useConstants ? constantValue : variable.Value;

    public FloatVariable Variable => variable;

    public static implicit operator float(FloatReference reference)
    {
        return reference.Value;
    }
}
