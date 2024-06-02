//------------------------------------------------------------------------------
// �ȖځF�v���O���~���O�Z�@
// ���e�F�_�o���� �J�[�h�R���g���[���[
// �S���FKen.D.Ohishi 2024.06.03
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryGameCardController : MonoBehaviour
{
    // ���̃X�N���v�g����l��������ϐ�
    public int cardNumber;
    public bool isClick;

    // �R���|�[�l���g�ۑ��ϐ�
    SpriteRenderer spRender;

    // cardNumber�̒l�ɑΉ������F�ϐ�
    Color[] col = {
        Color.red,      // cardNumber = 0
        Color.green,    // cardNumber = 1
        Color.blue,     // cardNumber = 2
        Color.yellow,   // cardNumber = 3
        Color.magenta   // cardNumber = 4
    };

    void Start()
    {
        // �X�v���C�g�����_���[�R���|�[�l���g�̏���ۑ�
        spRender = GetComponent<SpriteRenderer>();

        // �N���b�N�t���O��OFF�ɂ���
        isClick = false;
    }

    void Update()
    {
        if(isClick)
        {
            // �N���b�N�t���O��ON�̎���cardNumber�ɑΉ������F�ŕ\��
            spRender.color = col[cardNumber];
        }
        else
        {
            // �N���b�N�t���O��OFF�̎��͔��F�ŕ\��
            spRender.color = Color.white;
        }
    }
}
