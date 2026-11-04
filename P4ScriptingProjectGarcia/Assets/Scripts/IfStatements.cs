using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

    //Creating the vvariables for my script

    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        //This if statement is going to check the temperature of the coffee
        if (coffeeTemperature >= hotLimitTemperature)
        {
            Debug.Log("The coffee is too hot to drink");
        }
        //This else if statement is going to check if the coffee is too cold to drink
        else if (coffeeTemperature <= coldLimitTemperature)
        {
            Debug.Log("The coffee is too cold to drink");
        }
        //This else statement is gooing to check if the coffee is just right to drink
        else
        {
            Debug.Log("The coffee is just right");
        }
    }
}