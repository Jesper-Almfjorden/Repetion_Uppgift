using UnityEngine;
using System.Collections;

public class Uppgift1_variabel : MonoBehaviour {

    int a = 10;
    int b = 20;
    int c = 0;

	// Use this for initialization
	void Start ()
    {      
        Debug.Log(a);
        Debug.Log(b);       

        c = a;
        a = b;
        b = c;
              
        Debug.Log(a);
        Debug.Log(b);


	}
	
}
