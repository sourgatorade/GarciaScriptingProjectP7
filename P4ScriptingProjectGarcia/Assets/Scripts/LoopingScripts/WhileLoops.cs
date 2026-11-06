using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    //Creating the variables for my script
    int cupsInTheSink = 4;

    // Start is called before the first frame update
    void Start()
    {
        //my while loop is going to check if there are cups in the sink and iff there are, it will wash them
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
