using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update

    public int numberOne; 
    public int numberTwo; 
    public int numberThree; 
    public int numberFour; 
    public int numberFive;
    private float variableDivision;
    public string mySentence;
    void Start()
    {
        variableDivision = (numberOne + numberTwo + numberThree + numberFour + numberFive) / 3;
        Debug.Log(variableDivision);
        Debug.Log(mySentence + " " + variableDivision);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
