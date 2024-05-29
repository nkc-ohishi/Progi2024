using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MemoryGameDirector : MonoBehaviour
{
    public GameObject cardPre;                  // カードのプレハブをセット
    public GameObject resultText;               // 結果を表示するテキスト
    public Text timeText;                       // 時間を表示するテキスト
    float timeCount;                            // 経過時間
    bool timeFlg;                               // 時間フラグ
    int lastCardCnt;                            // カードの残り枚数
    int clickCnt;                               // クリック数カウント用

    GameObject[] cards = new GameObject[10];    // カードのゲームオブジェクトを保存する変数
    GameObject[] checkCard = new GameObject[2]; // 判定用の変数

    // カード番号テーブル（後でシャッフルする）
    int[] cardNumber = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4 };

    void Start()
    {
        clickCnt    = 0;    // クリック回数
        lastCardCnt = 10;   // カードの残り枚数
        timeCount = 0f;     // 経過時間
        timeFlg = false;   // 時間開始フラグ

        // カード番号をシャッフルする
        for (int i= cardNumber.Length - 1; i>0; i--)
        {
            int j = Random.Range(0, i + 1);
            int k = cardNumber[i];
            cardNumber[i] = cardNumber[j];
            cardNumber[j] = k;
        }

        // シャッフル後のカード配列を確認（デバッグ用）
        //for (int i = 0; i < cardNumber.Length; i++)
        //{
        //    Debug.Log(cardNumber[i]);
        //}

        // カードを横５、縦２に並べる
        Vector3 offset   = new Vector3(-2.5f, -0.5f, 0);    // 左下のカードの座標
        Vector3 interval = new Vector3(1.5f, 2f, 0);        // 配置の間隔
        for (int y = 0; y < 2; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                // カウント変数を利用して、カードの配置座標を決定
                Vector3 pos = new Vector3(interval.x * x, interval.y * y, 0) + offset;

                // 0,1,2,3,4,0,1,2,3,4 を 0,1,2,3,4,5,6,7,8,9 にする計算式
                int n = x + y * 5;

                // プレハブからインスタンスを生成して配置
                cards[n] = Instantiate(cardPre, pos, Quaternion.identity);

                // コンポーネントを取得してcardNumberの値をセット
                MemoryGameCardController mgcc = cards[n].GetComponent<MemoryGameCardController>();
                mgcc.cardNumber = cardNumber[n];
            }
        }

        // 結果表示用テキストを非アクティブにする
        resultText.SetActive(false);
    }

    void Update()
    {
        // マウス左クリックされた瞬間
        if(Input.GetMouseButtonDown(0))
        {
            // カメラからクリック位置にレーザービームを発射！！
            Vector2 rayPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero);

            // レーザービームがゲームオブジェクトにヒット！！
            if(hit.collider != null && clickCnt < 2)
            {
                timeFlg = true;    // 最初のカードが開かれた時点でスタート

                // クリックされたカードを checkCard に保存
                checkCard[clickCnt] = hit.collider.gameObject;
                MemoryGameCardController mgcc = checkCard[clickCnt].GetComponent<MemoryGameCardController>();

                // clickされていないカードだったらクリックカウントを増やす
                if(mgcc.isClick == false)
                {
                    clickCnt++; // クリックカウントを増やす
                }

                // カードのclickフラグをONにする
                mgcc.isClick = true;
            }
        }

        // 判定は右クリック
        if (Input.GetMouseButtonDown(1))
        {
            // クリックカウントが２より小さい時は判定しない
            if(clickCnt < 2) return;

            // 選択されたカードのMemoryGameCardControllerコンポーネントを取得
            MemoryGameCardController mgcc1 = checkCard[0].GetComponent<MemoryGameCardController>();
            MemoryGameCardController mgcc2 = checkCard[1].GetComponent<MemoryGameCardController>();

            // 選択した２枚のカードが同じ色かどうかを判定
            if(mgcc1.cardNumber == mgcc2.cardNumber)
            {
                // クリックされた２枚のカードが同じ番号（色）なら消す
                Destroy(checkCard[0]);
                Destroy(checkCard[1]);
                lastCardCnt -= 2;   // カードの残り枚数を減らす
            }
            else
            {
                // クリックされた２枚のカードが違う番号ならクリックフラグをOFFにする
                mgcc1.isClick = false;
                mgcc2.isClick = false;
            }

            // クリックカウントを初期化
            clickCnt = 0;
        }

        // 経過時間測定
        if(timeFlg)
        {
            // 時間を加算し、表示に反映
            timeCount += Time.deltaTime;
            timeText.text = "Time " + timeCount.ToString("F2") + "秒";
        }

        // クリア判定
        if(lastCardCnt == 0)
        {
            // クリアの表示
            resultText.SetActive(true);

            // 時間経過停止
            timeFlg = false;

            // シーンをリロード
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("GameScene");
            }
        }
    }
}
