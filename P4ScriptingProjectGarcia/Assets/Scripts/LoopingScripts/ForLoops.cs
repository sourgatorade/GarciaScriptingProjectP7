using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    //Creating the variables for my script 
    int numEnemies = 3;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; 1< numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
