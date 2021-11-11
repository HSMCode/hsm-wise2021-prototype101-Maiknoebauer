using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLog : MonoBehaviour
{
    // Start is called before the first frame update
    private new int number;
    private new int count;
    void Start()
    {
        Debug.Log("Here, read my debug text");
        number = 1;
        Debug.Log(number);
        Debug.Log("Text:" + gameObject.name);
        Debug.Log("<color=red>Error: </color> Not found!");
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count<= 100)
        {
            Debug.Log(count);
        }
    }
}
