//------------------------------------------------------------------------------
// 科目：プログラミング技法
// 内容：３の倍数なら勝ちシステム
// 担当：Ken.D.Ohishi 2024.05.20
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Number3 : MonoBehaviour
{
    public Text numLabel;       // 乱数表示用
    public Text resultLabel;    // 勝ち or 負け表示用
    public Text syouhaiLabel;   // 勝敗表示用

    int num;                    // 乱数の値保存
    int winNum;                 // 勝ち数
    int loseNum;                // 負け数
    int clickCnt;               // クリックされた回数カウント

    void Start()
    {
        clickCnt = 0;
        num      = -999;
        winNum   = 0;
        loseNum  = 0;
        resultLabel.text = "判定";
    }

    void Update()
    {
        // クリックされる毎にswの値をインクリメント
        if(Input.GetMouseButtonDown(0))
        {
            clickCnt++;
        }

        if(clickCnt == 1)
        {
            // 乱数表示
            num = Random.Range(0, 1000);
            numLabel.text = num.ToString("D3");
        }
        else if(clickCnt == 2)
        {
            // 判定結果を更新
            if (num % 3 == 0)
            {
                resultLabel.text = "勝ち";
                winNum++;
            }
            else
            {
                resultLabel.text = "負け";
                loseNum++;
            }

            // 判定結果を更新後、swを0に戻す
            clickCnt = 0; 
        }

        // 勝敗表示
        string winstr  = winNum.ToString("D2");
        string losestr = loseNum.ToString("D2");
        syouhaiLabel.text = winstr + "勝" + losestr + "負";

        // Enterキーでリセット
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }        
    }
}
