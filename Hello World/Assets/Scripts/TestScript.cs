using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public bool testBool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CompareNumbers(int a, int b)
    {

        if (a < b)
        {
            Debug.Log("a ist kleiner als b");
        }
        else if (a > b)
        {
            Debug.Log("a ist größer als b");
        }
        else
        {
            //Debug.Log
        }

    }
  
}
