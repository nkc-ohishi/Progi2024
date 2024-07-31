//------------------------------------------------------------------------------
// 科目：プログラミング技法
// 内容：インプットフィールド
// 担当：Ken.D.Ohishi 2024.06.24
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class ren0624 : MonoBehaviour
{
    public InputField inputField;
    public Text resultText;
    public Image saintGraph;

    const int DATA_MAX = 3;
    public Sprite[] sprites;
 
    string[] servantName =
    {
        "ドラコー",
        "バサトリア",
        "ドレイク"
    };

    string[] hogu =
    {
        "ベイバロン・ドムス・アウレア",
        "ホープウィル・キャメロット",
        "ゴールデン・ワイルドハント",
        "No Data"
    };

    public void EndEdit()
    {        
        int no = CheckData(inputField.text);
        saintGraph.sprite = sprites[no];
        resultText.text = hogu[no];
    }

    int CheckData(string str)
    {
        int num = DATA_MAX;
        for(int i=0; i< DATA_MAX; i++)
        {
            if (str == servantName[i])
            {
                num = i;
                break;
            }
        }
        return num;
    }
}
