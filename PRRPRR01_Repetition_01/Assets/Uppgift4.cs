using UnityEngine;
using System.Collections;

public class Uppgift4 : MonoBehaviour {

    public int a = 30;
    public int b = 10;
    public int c = 20;

    // Use this for initialization
    void Start()
    {
        // if a is > then b and if b is < then c print the value on b
        if (a > b && b < c)
        {
            print(b);
        }
	
	}
}
