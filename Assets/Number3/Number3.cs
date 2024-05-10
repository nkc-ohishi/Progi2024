using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number3 : MonoBehaviour
{
    Text numLabel;
    Text resultLabel;

    int num;
    bool sw;

    // Start is called before the first frame update
    void Start()
    {
        sw = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            sw = (sw) ? false : true;
        }

        if(sw)
        {
            num = Random.Range(0, 999);

        }
        else
        {
            if(num % 3 == 0)
            {
                resultLabel.text = "èüÇø";
            }
            else
            {
                resultLabel.text = "ïâÇØ";
            }
        }

        
    }
}
