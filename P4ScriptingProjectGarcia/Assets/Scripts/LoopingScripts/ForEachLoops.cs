using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //creating an array of strings to use in my for each loop
        string[] strings = new string[3];

        //assign a string value to each index of the array
        strings[0] = "First String";
        strings[1] = "Second String";
        strings[2] = "Third String";

        foreach (string item in strings)
        {
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
