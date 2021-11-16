using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLog : MonoBehaviour
{
    // Start is called before the first frame update
    private new int _number;
    private new int _count;
    void Start()
    {
        Debug.Log("Here, read my debug text");
        _number = 1;
        Debug.Log(_number);
        Debug.Log("Text:" + gameObject.name);
        Debug.Log("<color=red>Error: </color> Not found!");
        _count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _count++;
        if (_count<= 100)
        {
            Debug.Log(_count);
        }
    }
}
