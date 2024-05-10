using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController0510 : MonoBehaviour
{
    float speed;
    int life;

    public Text lifeLabel;
    public GameObject kaifukuPoint;

    void Start()
    {
        speed = 5f;
        life = 100;
        
    }

    void Update()
    {
        // 上下左右に動かす
        Vector3 dir = Vector3.zero; // (x,y,z) = (0,0,0)

        if(Input.GetKey(KeyCode.RightArrow))
        {
            dir.x = 1;
            life++;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir.x = -1;
            life--;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            dir.y = 1;
            life++;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            dir.y = -1;
            life--;
        }

        // 回復ポイントに重なったら
        Vector3 v = kaifukuPoint.transform.position - transform.position;
        float length = v.magnitude;
        if(length < 1f)
        {
            life += 10000;
            float x = Random.Range(-8, 8);
            float y = Random.Range(-4, 4);
            kaifukuPoint.transform.position = new Vector3(x, y, 0);
        }


        transform.position += dir * speed * Time.deltaTime;

        // ライフを表示
        lifeLabel.text = "Life = " + life.ToString("D6");

        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }

    }
}
