//------------------------------------------------------------------------------
// �ȖځF�v���O���~���O�Z�@
// ���e�F�R�̔{���Ȃ珟���V�X�e��
// �S���FKen.D.Ohishi 2024.05.20
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Number3 : MonoBehaviour
{
    public Text numLabel;       // �����\���p
    public Text resultLabel;    // ���� or �����\���p
    public Text syouhaiLabel;   // ���s�\���p

    int num;                    // �����̒l�ۑ�
    int winNum;                 // ������
    int loseNum;                // ������
    int clickCnt;               // �N���b�N���ꂽ�񐔃J�E���g

    void Start()
    {
        clickCnt = 0;
        num      = -999;
        winNum   = 0;
        loseNum  = 0;
        resultLabel.text = "����";
    }

    void Update()
    {
        // �N���b�N����閈��sw�̒l���C���N�������g
        if(Input.GetMouseButtonDown(0))
        {
            clickCnt++;
        }

        if(clickCnt == 1)
        {
            // �����\��
            num = Random.Range(0, 1000);
            numLabel.text = num.ToString("D3");
        }
        else if(clickCnt == 2)
        {
            // ���茋�ʂ��X�V
            if (num % 3 == 0)
            {
                resultLabel.text = "����";
                winNum++;
            }
            else
            {
                resultLabel.text = "����";
                loseNum++;
            }

            // ���茋�ʂ��X�V��Asw��0�ɖ߂�
            clickCnt = 0; 
        }

        // ���s�\��
        string winstr  = winNum.ToString("D2");
        string losestr = loseNum.ToString("D2");
        syouhaiLabel.text = winstr + "��" + losestr + "��";

        // Enter�L�[�Ń��Z�b�g
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }        
    }
}
