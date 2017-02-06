using UnityEngine;
using System.Collections;

public class Uppgift5 : MonoBehaviour {

    int num1 = 5;
    int num2 = 5;
    int max = 40;
    int min = 20;

    // Use this for initialization
    public void Start()
    {
        int ab = Add(5, 5);
        {
            if(max > ab && ab < min)
            {
                print(ab);
            }
        }
    }

    public int Add(int a, int b)
    {
        return a + b;
        {
        }
    }
}