//------------------------------------------------------------------------------
// 科目：プログラミング技法
// 内容：メソッド
// 担当：Ken.D.Ohishi 2024.06.17
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class ren0617 : MonoBehaviour
{
    public Sprite[] sprites;

    public InputField inputField;
    public Text resultText;
    public SpriteRenderer img;

    void Start()
    {
        //Shop(); // 自作メソッドの呼び出し

        img.sprite = sprites[0];
    }

    void Update()
    {
        
    }

    // テキスト内容の変数を終えたときに実行されるメソッド
    public void EndEdit()
    {
        Shop();
    }

    // P100 List 3-18 引数なし、戻り値なしのメソッド
    //void Shop()
    //{
    //    Debug.Log("いらっしゃいませ");
    //}

    int CheckData(string str)
    {
        int num = 9999;



        return num;
    }

    void Shop()
    {
        string itemName = inputField.text;
        string resultStr;

        // 入力されたデータと一致する番号を検索
        int no = CheckData(inputField.text);


        if(itemName == "薬草")
        {
            resultText.text = "【"+ itemName + "】は100ゴールドです";
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
