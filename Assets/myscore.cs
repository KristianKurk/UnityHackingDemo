using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myscore : MonoBehaviour
{
    //Our values - One safe, one unsafe.
    public SafeInt myScore;
    public int nonSecure;

    private void Start()
    {
        //Initialise our values.
        myScore = new SafeInt(100);
        nonSecure = 100;

        //Execute our test case!
        print("Is the non secured value changed? "+testCase(nonSecure, 100));
        print("Is the secured value changed? " + testCase(myScore.GetRawValue(), 100));
        print("If the program works correctly, then the secured value will be different.");
        print("This prevents hackers from finding the value in the memory.");
    }

    void Update()
    {
        //Display the value.
        GetComponent<UnityEngine.UI.Text>().text = myScore.ToString();
    }

    public void Decrease()
    {
        //Decrease the value by one. Called by the button.
        myScore.SetValue((myScore.GetValue())-1);
    }

    private bool testCase(int value, int expected)
    {
        //Check to see if the value is changed.
        return value != expected;
    }
}
