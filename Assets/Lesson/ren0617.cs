//------------------------------------------------------------------------------
// 科目：プログラミング技法
// 内容：メソッド
// 担当：Ken.D.Ohishi 2024.06.17
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ren0617 : MonoBehaviour
{
    public InputField inputField;
    public Text resultText;

    void Start()
    {
        //Shop(); // 自作メソッドの呼び出し
    }

    void Update()
    {
        
    }

    // テキスト内容の変数を終えたときに実行されるメソッド
    public void EndEdit()
    {
        Shop(inputField.text);
    }

    // P100 List 3-18 引数なし、戻り値なしのメソッド
    //void Shop()
    //{
    //    Debug.Log("いらっしゃいませ");
    //}

    void Shop(string itemName)
    {
        Debug.Log("いらっしゃいませ");

        if(itemName == "薬草")
        {
            resultText.text = itemName + "は100ゴールドです";
        }
        else if(itemName == "ヒノキの棒")
        {
            resultText.text = itemName + "は1500ゴールドです";
        }
        else
        {
            resultText.text = itemName + "はありません";
        }
    }

}
