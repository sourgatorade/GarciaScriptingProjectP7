using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    //adding a public variable to the class
    public int alpha = 5;

  //adding a private variable to the cl;ass
 private int beta = 0;
 private int gamma = 5;

    //add access to another class
    private AnotherClass myOtherClass;
       
    
    
    // Start is called before the first frame update
    void Start()
    {
        //change starting value of alpha
        alpha = 29;

        //I can change or acceess another class
        myOtherClass = new AnotherClass();

        //I am going to use the method in another class
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }
    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log("The answer is:" + answer);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
