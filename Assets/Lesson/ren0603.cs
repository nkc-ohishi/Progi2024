//------------------------------------------------------------------------------
// 科目：プログラミング技法
// 内容：配列
// 担当：Ken.D.Ohishi 2024.06.03
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ren0603 : MonoBehaviour
{
    public Text info;

    void Start()
    {
        // List 3-15 P87
        float[] weights;                    // 配列用の変数を宣言する
        weights = new float[7];             // 配列の要素を決める
        float[] weights2 = new float[7];    // 宣言と要素は1行で記述することもできる

        // 配列変数に値を代入する
        // 変数名[インデックス番号] = 保存する値
        weights[0] = 41.2f;
        weights[1] = 42.5f;
        weights[2] = 44.9f;
        weights[3] = 43.2f;
        weights[4] = 45.1f;
        weights[5] = 43.2f;
        weights[6] = 42.7f;

        // 配列の要素数を取得
        float length = weights.Length;
        Debug.Log(weights.Length);

        // 配列の値をすべて表示
        for (int i=0; i<weights.Length; i++)
        {
            Debug.Log(weights[i]);
        }

        // 配列の宣言＆初期化
        float[] weights3 = { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f, 43.2f, 42.7f };

        // C#独自のループ foreach
        // 配列の要素すべてにアクセスする場合はこちらのが簡潔に記述できる
        foreach(float w in weights3)
        {
            Debug.Log(w);
        }

        // List 3-17 ７日間の平均体重を求めるプログラム
        float sum = 0f;
        for(int i=0; i<weights3.Length; i++)
        {
            sum += weights3[i];
        }
        float avg = sum / weights3.Length;
        Debug.Log("平均体重 = " + avg);

        // 練習問題 3-18
        // weights配列の中から43以下だけを表示するプログラムを作ってください。
        for (int i = 0; i < weights.Length; i++)
        {
            if (weights[i] <= 43f)
            {
                Debug.Log(weights[i]);
            }
        }

        // 追加問題
        // weights配列の中に、43以下の値がいくつあるかをカウントするプログラムを作ってください。
        int cnt = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            if (weights[i] <= 43f)
            {
                cnt++;
                Debug.Log(weights[i]);
            }
        }
        Debug.Log("43以下の値の数 = " + cnt);

        // 練習問題
        // 10回のダメージの値が 9,3,6,4,9,9,7,7,8,6 の時、平均のダメージを計算して表示する
        // プログラムを作ってください。

        //２次元配列
        int[,] a = new int[2, 3];
        a[0, 0] = 1;
        a[0, 1] = 2;
        a[0, 2] = 3;
        a[1, 0] = 4;
        a[1, 1] = 5;
        a[1, 2] = 6;

        int[,] b = { { 10, 20, 30 }, { 40, 50, 60 } };

        // ２次元配列の要素数
        Debug.Log(a.Length);        // 6
        Debug.Log(a.GetLength(0));  // 2
        Debug.Log(a.GetLength(1));  // 3

        for (int y= 0; y<2; y++)
        {
            for(int x=0; x<3; x++)
            {
                Debug.Log(a[y,x]);
            }
        }
    }

}
