//------------------------------------------------------------------------------
// 科目：プログラミング技法
// 内容：2重ループ テーブル
// 担当：Ken.D.Ohishi 2024.05.27
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTable : MonoBehaviour
{
    public GameObject card;
    public Text table;
    string resultStr = "";

    void Start()
    {
        // 00 ～ 49 のテーブル
        //for(int y=0; y<5; y++)
        //{
        //    for(int x=0; x<10; x++)
        //    {
        //        int num = x + y * 10;
        //        resultStr += num.ToString("D2") + " ";
        //    }
        //    resultStr += "\n";
        //}
        //table.text = resultStr;

        // オブジェクトテーブル
        Vector3 anchorPoint = new Vector3(-7, -4, 0);
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 10; x++)
            {
                Vector3 pos = anchorPoint + new Vector3(x, y, 0);
                Instantiate(card, pos, Quaternion.identity);
            }
        }

        // 問１．
        // ■
        // ■■
        // ■■■
        //for (int y = 0; y < 3; y++)
        //{
        //    for (int x = 0; x < y+1; x++)
        //    {
        //        resultStr += "■";
        //    }
        //    resultStr += "\n";
        //}
        //table.text = resultStr;

        // 問２．
        // ■■■
        // ■■
        // ■
        //for (int y = 0; y < 3; y++)
        //{
        //    for (int x = 3; x > y ; x--)
        //    {
        //        resultStr += "■";
        //    }
        //    resultStr += "\n";
        //}
        //table.text = resultStr;

        // 問３．
        // 　　■
        // 　■■■
        // ■■■■■
        //for (int y = 0; y < 3; y++)
        //{
        //    for (int x = 3; x > y; x--)
        //    {
        //        resultStr += "□";
        //    }
        //    for (int x = 0; x < y*2+1; x++)
        //    {
        //        resultStr += "■";
        //    }
        //    resultStr += "\n";
        //}
        //table.text = resultStr;

        // 問４．
        // ■■■■■
        // 　■■■
        // 　　■
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < y; x++)
            {
                resultStr += "□";
            }
            for (int x = y*2 ; x<5 ; x++)
            {
                resultStr += "■";
            }
            resultStr += "\n";
        }
        table.text = resultStr;


    }
}
// 練習問題
// カードを以下のように並べてみよう
// 問１．
// ■
// ■■
// ■■■
// 問２．
// ■■■
// ■■
// ■
// 問３．
// 　　■
// 　■■■
// ■■■■■
// 問４．
// ■■■■■
// 　■■■
// 　　■

// 考えてみよう
// 50枚のカードを横10,縦5に並べ、01～50の番号を表示させよう