//------------------------------------------------------------------------------
// �ȖځF�v���O���~���O�Z�@
// ���e�F���\�b�h
// �S���FKen.D.Ohishi 2024.06.17
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ren0617 : MonoBehaviour
{
    public InputField inputField;
    public Text resultText;

    void Start()
    {
        //Shop(); // ���상�\�b�h�̌Ăяo��
    }

    void Update()
    {
        
    }

    // �e�L�X�g���e�̕ϐ����I�����Ƃ��Ɏ��s����郁�\�b�h
    public void EndEdit()
    {
        Shop(inputField.text);
    }

    // P100 List 3-18 �����Ȃ��A�߂�l�Ȃ��̃��\�b�h
    //void Shop()
    //{
    //    Debug.Log("��������Ⴂ�܂�");
    //}

    void Shop(string itemName)
    {
        Debug.Log("��������Ⴂ�܂�");

        if(itemName == "��")
        {
            resultText.text = itemName + "��100�S�[���h�ł�";
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
