//------------------------------------------------------------------------------
// 科目：プログラミング技法
// 内容：メソッドの基本パターン３つ
// 担当：Ken.D.Ohishi 2024.06.21
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ren0621 : MonoBehaviour
{
    void Start()
    {
        // func1 引数なし、戻り値なし
        func1();

        // func2 引数あり、戻り値なし
        func2(100);

        // func3 引数あり、戻り値あり
        string str = func3(100);
        Debug.Log(str);

        // 問題１．以下の仕様通り、引数なし、戻り値なしのメソッドを作成しなさい。
        // メソッド名：nkc
        // nkcメソッドの処理内容：
        // 「nkcメソッド君はstartメソッド君から呼び出されたので、ジュースを買いにいきました。」
        // と表示
        // nkc(); // 呼び出し方

        // 問題２．以下の仕様通り、引数あり、戻り値なしのメソッドを作成しなさい。
        // メソッド名：nkc2
        // nkcメソッドの処理内容：
        // 「nkc2メソッド君はstartメソッド君から〇円渡されたので、〇〇を買いにいきました。」
        // と表示（〇は引数の値、〇〇は引数の値に応じた商品名前
        // 引数：100 商品：水
        // 引数：150 商品：お茶
        // 引数：300 商品：コーヒー
        // 引数：690 商品：バナナブリュレフラペチーノ
        // 呼び出し方
        // nkc2(100); // nkc2メソッド君はstartメソッド君から100円渡されたので、水を買いにいきました。

        // 問題３．以下の仕様通り、引数あり、戻り値ありのメソッドを作成しなさい。
        // メソッド名：nkc3
        // nkc3メソッドの処理内容：
        // 「nkc3メソッド君はstartメソッド君から〇円渡されたので、〇〇をスタートメソッドに戻しました」
        // と表示（〇は引数の値、〇〇は引数の値に応じた商品名前
        // 引数：100 商品：水
        // 引数：150 商品：お茶
        // 引数：300 商品：コーヒー
        // 引数：690 商品：バナナブリュレフラペチーノ
        // 呼び出し方
        // string str = nkc3(150);
        // Debug.Log(str); // nkc3メソッド君はstartメソッド君から150円渡されたので、お茶をスタートメソッドに戻しました

        // 問題3-19．
        // 「ありがとうございました」と表示するThankyouメソッドを作ってください。

        // 問題3-20．
        // 引数にint型の整数値を受け取り、その値が偶数なら「偶数です」
        // 奇数なら「奇数です」と表示するShowEvenOrOddメソッドを作ってください

        // 問題3-21．
        // Shopメソッドの商品に500円の万能薬追加
        // また、以下に薬草に続けて万能薬を購入する命令を追加
        int money = 2500;
        Debug.Log("所持金：" + money + "円");
        int price = Shop("薬草");
        money -= price;
        Debug.Log("所持金：" + money + "円");

        // 問題3-22.
        // int型の引数を３つ受け取り、その平均値をfloat型で返すCalcAverageメソッドを作ってください。
        // float avg = CalcAverage(90,80,60);
        // Debug.Log("平均:" + avg);

    }

    // func1 引数なし、戻り値なし
    void func1()
    {
        Debug.Log("引数なし、戻り値なしのメソッド");
    }

    // func2 引数あり、戻り値なし
    void func2(int a)
    {
        Debug.Log("引数:" + a + " 戻り値なしのメソッド");
    }

    // func3 引数あり、戻り値あり
    string func3(int a)
    {
        string result = "";
        if(a >= 1000)
        {
            result = "startメソッドより、1000以上の値を受け取りました。";
        }
        else
        {
            result = "startメソッドより、1000未満の値を受け取りました。";
        }
        return result;
    }

    // List 3-20 ショップメソッド
    int Shop(string itemName)
    {
        int price = 0;

        if(itemName == "薬草")
        {
            Debug.Log(itemName + "は100円です");
            price = 100;
        }
        else if (itemName == "棍棒")
        {
            Debug.Log(itemName + "は1500円です");
            price = 1500;
        }
        else
        {
            Debug.Log(itemName + "はありません");
            price = 0;
        }
        return price;
    }
}
