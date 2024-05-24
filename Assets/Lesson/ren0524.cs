//------------------------------------------------------------------------------
// 科目：プログラミング技法
// 内容：for文, while文
// 担当：Ken.D.Ohishi 2024.05.24
//------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI;

public class ren0524 : MonoBehaviour
{
    public Text info;

    void Start()
    {
        // List 3-11
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("攻撃");
        }

        // ren 3-12
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("逃走！");
        }

        // List 3-12
        for (int i = 1; i < 4; i++)
        {
            Debug.Log(i + "番");
        }

        // ren 3-13
        for (int i = 2; i < 6; i++)
        {
            Debug.Log(i);
        }

        // ren 3-14
        for (int i = 0; i < 5; i += 2)
        {
            Debug.Log(i);
        }

        // List 3-13
        for (int i = 3; i > 0; i--)
        {
            Debug.Log(i);
        }
        Debug.Log("スタート");

        // ren 3-15
        for (int i = 10; i >= 0; i--)
        {
            Debug.Log(i);
        }

        // List 3-14a
        int playerPosX = 5;
        int missilePosX = 15;
        while (playerPosX != missilePosX)
        {
            Debug.Log("missile at " + missilePosX);
            missilePosX--;
        }
        Debug.Log("HIT");

        // ren 3-16
        int num1 = 10000;
        int num2 = 2;
        int cnt1 = 0;
        while (num1 > 100)
        {
            num1 /= num2;
            // Debug.Log(num1);
            cnt1++;
        }
        Debug.Log(cnt1 + "回");


        // List 3-14b
        while (true)
        {
            if (playerPosX == missilePosX)
            {
                break;
            }
            Debug.Log("missile at" + missilePosX);
            missilePosX--;
        }
        Debug.Log("Hit");

        // ren 3-17
        int gou = 0;
        int cnt2 = 1;
        while (true)
        {
            gou += cnt2;
            cnt2++;
            Debug.Log(gou);
            if (gou > 500)
            {
                break;
            }
        }
    }
}
