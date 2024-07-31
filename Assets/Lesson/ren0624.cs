//------------------------------------------------------------------------------
// �ȖځF�v���O���~���O�Z�@
// ���e�F�C���v�b�g�t�B�[���h
// �S���FKen.D.Ohishi 2024.06.24
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
        "�h���R�[",
        "�o�T�g���A",
        "�h���C�N"
    };

    string[] hogu =
    {
        "�x�C�o�����E�h���X�E�A�E���A",
        "�z�[�v�E�B���E�L�������b�g",
        "�S�[���f���E���C���h�n���g",
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
