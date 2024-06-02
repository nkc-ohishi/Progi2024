//------------------------------------------------------------------------------
// 科目：プログラミング技法
// 内容：神経衰弱 カードコントローラー
// 担当：Ken.D.Ohishi 2024.06.03
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryGameCardController : MonoBehaviour
{
    // 他のスクリプトから値を代入する変数
    public int cardNumber;
    public bool isClick;

    // コンポーネント保存変数
    SpriteRenderer spRender;

    // cardNumberの値に対応した色変数
    Color[] col = {
        Color.red,      // cardNumber = 0
        Color.green,    // cardNumber = 1
        Color.blue,     // cardNumber = 2
        Color.yellow,   // cardNumber = 3
        Color.magenta   // cardNumber = 4
    };

    void Start()
    {
        // スプライトレンダラーコンポーネントの情報を保存
        spRender = GetComponent<SpriteRenderer>();

        // クリックフラグをOFFにする
        isClick = false;
    }

    void Update()
    {
        if(isClick)
        {
            // クリックフラグがONの時はcardNumberに対応した色で表示
            spRender.color = col[cardNumber];
        }
        else
        {
            // クリックフラグがOFFの時は白色で表示
            spRender.color = Color.white;
        }
    }
}
