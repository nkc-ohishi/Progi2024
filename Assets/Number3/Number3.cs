using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Number3 : MonoBehaviour
{
    public Text numLabel;
    public Text resultLabel;

    int num;
    bool sw;

    void Start()
    {
        sw = false;
        num = -999;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            sw = (sw) ? false : true;
        }

        if(sw)
        {
            num = Random.Range(0, 999);
            numLabel.text = num.ToString("D3");
        }
        else
        {
            if(num == -999)
            {
                resultLabel.text = "判定";
                return;
            }

            if (num % 3 == 0)
            {
                resultLabel.text = "勝ち";
            }
            else
            {
                resultLabel.text = "負け";
            }
        }

        // Enterキーでリセット
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }

        
    }
}
