using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct SafeInt
{
    private int offset;     //a randomly generated value.
    private int value;      //our secured value.

    public SafeInt(int value = 0)
    {
        //Assign a random value to our offset.
        offset = Random.Range(-1000, 1000);
        //Set the secure value.
        this.value = value + offset;
    }

    public int GetValue()
    {
        //Return the real value.
        return value - offset;
    }

    public int GetRawValue()
    {
        //Return the secured value.
        return value;
    }

    public void SetValue(int newValue)
    {
        //Generate a new offset and insert a new value.
        Dispose();
        offset = Random.Range(-1000, 1000);
        value = newValue + offset;
    }

    public void Dispose()
    {
        //Clear our values.
        offset = 0;
        value = 0;
    }

    public override string ToString()
    {
        return GetValue().ToString();
    }

}
