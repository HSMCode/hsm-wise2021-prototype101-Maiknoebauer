using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TwentyFaceDice : MonoBehaviour
{
    // Start is called before the first frame update
    private int _randomNumber;
    public string _winningString;
    void Start()
    {
        _randomNumber=Random.Range(1, 20);
        Debug.Log("Du hast "+_randomNumber+" gewürfelt. Drücke Space um nochmal zu Würfeln");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _randomNumber=Random.Range(1, 20);
            Debug.Log("Du hast "+_randomNumber+" gewürfelt. Drücke Space um nochmal zu Würfeln");
            if (_randomNumber == 4 || _randomNumber == 8 || _randomNumber == 13)
            {
                Debug.Log(_winningString + _randomNumber);
            }
        }
    }
}
