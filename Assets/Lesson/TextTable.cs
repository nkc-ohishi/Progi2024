//------------------------------------------------------------------------------
// �ȖځF�v���O���~���O�Z�@
// ���e�F2�d���[�v �e�[�u��
// �S���FKen.D.Ohishi 2024.05.27
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
        // 00 �` 49 �̃e�[�u��
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

        // �I�u�W�F�N�g�e�[�u��
        Vector3 anchorPoint = new Vector3(-7, -4, 0);
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 10; x++)
            {
                Vector3 pos = anchorPoint + new Vector3(x, y, 0);
                Instantiate(card, pos, Quaternion.identity);
            }
        }

        // ��P�D
        // ��
        // ����
        // ������
        //for (int y = 0; y < 3; y++)
        //{
        //    for (int x = 0; x < y+1; x++)
        //    {
        //        resultStr += "��";
        //    }
        //    resultStr += "\n";
        //}
        //table.text = resultStr;

        // ��Q�D
        // ������
        // ����
        // ��
        //for (int y = 0; y < 3; y++)
        //{
        //    for (int x = 3; x > y ; x--)
        //    {
        //        resultStr += "��";
        //    }
        //    resultStr += "\n";
        //}
        //table.text = resultStr;

        // ��R�D
        // �@�@��
        // �@������
        // ����������
        //for (int y = 0; y < 3; y++)
        //{
        //    for (int x = 3; x > y; x--)
        //    {
        //        resultStr += "��";
        //    }
        //    for (int x = 0; x < y*2+1; x++)
        //    {
        //        resultStr += "��";
        //    }
        //    resultStr += "\n";
        //}
        //table.text = resultStr;

        // ��S�D
        // ����������
        // �@������
        // �@�@��
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < y; x++)
            {
                resultStr += "��";
            }
            for (int x = y*2 ; x<5 ; x++)
            {
                resultStr += "��";
            }
            resultStr += "\n";
        }
        table.text = resultStr;


    }
}
// ���K���
// �J�[�h���ȉ��̂悤�ɕ��ׂĂ݂悤
// ��P�D
// ��
// ����
// ������
// ��Q�D
// ������
// ����
// ��
// ��R�D
// �@�@��
// �@������
// ����������
// ��S�D
// ����������
// �@������
// �@�@��

// �l���Ă݂悤
// 50���̃J�[�h����10,�c5�ɕ��ׁA01�`50�̔ԍ���\�������悤