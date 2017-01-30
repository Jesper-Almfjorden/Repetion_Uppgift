using UnityEngine;
using System.Collections;

public class Uppgift2 : MonoBehaviour {

    public int a = 1;
    public int b = 2;

	// Use this for initialization
	void Start ()
    {
        if (a < b)
        {
            print(b);
        }
        if(b > a)
        {
            print(a);
        }
	}
	
}
