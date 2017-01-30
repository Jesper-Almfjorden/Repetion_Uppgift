using UnityEngine;
using System.Collections;

public class Uppgift3 : MonoBehaviour {

    public void Start()
    {
        int a = Add(1, 2);

        print(a);
    }
    // The code is going to addition a and b to one
    public int Add(int a, int b)
    {
        return a + b;
    }
         
}

