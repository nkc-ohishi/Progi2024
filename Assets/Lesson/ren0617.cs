//------------------------------------------------------------------------------
// �ȖځF�v���O���~���O�Z�@
// ���e�F���\�b�h
// �S���FKen.D.Ohishi 2024.06.17
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class ren0617 : MonoBehaviour
{
    public Sprite[] sprites;

    public InputField inputField;
    public Text resultText;
    public SpriteRenderer img;

    void Start()
    {
        //Shop(); // ���상�\�b�h�̌Ăяo��

        img.sprite = sprites[0];
    }

    void Update()
    {
        
    }

    // �e�L�X�g���e�̕ϐ����I�����Ƃ��Ɏ��s����郁�\�b�h
    public void EndEdit()
    {
        Shop();
    }

    // P100 List 3-18 �����Ȃ��A�߂�l�Ȃ��̃��\�b�h
    //void Shop()
    //{
    //    Debug.Log("��������Ⴂ�܂�");
    //}

    int CheckData(string str)
    {
        int num = 9999;



        return num;
    }

    void Shop()
    {
        string itemName = inputField.text;
        string resultStr;

        // ���͂��ꂽ�f�[�^�ƈ�v����ԍ�������
        int no = CheckData(inputField.text);


        if(itemName == "��")
        {
            resultText.text = "�y"+ itemName + "�z��100�S�[���h�ł�";
        }
        else if(itemName == "�q�m�L�̖_")
        {
            resultText.text = itemName + "��1500�S�[���h�ł�";
        }
        else
        {
            resultText.text = itemName + "�͂���܂���";
        }
    }

}
