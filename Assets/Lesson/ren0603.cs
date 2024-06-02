//------------------------------------------------------------------------------
// �ȖځF�v���O���~���O�Z�@
// ���e�F�z��
// �S���FKen.D.Ohishi 2024.06.03
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ren0603 : MonoBehaviour
{
    public Text info;

    void Start()
    {
        // List 3-15 P87
        float[] weights;                    // �z��p�̕ϐ���錾����
        weights = new float[7];             // �z��̗v�f�����߂�
        float[] weights2 = new float[7];    // �錾�Ɨv�f��1�s�ŋL�q���邱�Ƃ��ł���

        // �z��ϐ��ɒl��������
        // �ϐ���[�C���f�b�N�X�ԍ�] = �ۑ�����l
        weights[0] = 41.2f;
        weights[1] = 42.5f;
        weights[2] = 44.9f;
        weights[3] = 43.2f;
        weights[4] = 45.1f;
        weights[5] = 43.2f;
        weights[6] = 42.7f;

        // �z��̗v�f�����擾
        float length = weights.Length;
        Debug.Log(weights.Length);

        // �z��̒l�����ׂĕ\��
        for (int i=0; i<weights.Length; i++)
        {
            Debug.Log(weights[i]);
        }

        // �z��̐錾��������
        float[] weights3 = { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f, 43.2f, 42.7f };

        // C#�Ǝ��̃��[�v foreach
        // �z��̗v�f���ׂĂɃA�N�Z�X����ꍇ�͂�����̂��Ȍ��ɋL�q�ł���
        foreach(float w in weights3)
        {
            Debug.Log(w);
        }

        // List 3-17 �V���Ԃ̕��ϑ̏d�����߂�v���O����
        float sum = 0f;
        for(int i=0; i<weights3.Length; i++)
        {
            sum += weights3[i];
        }
        float avg = sum / weights3.Length;
        Debug.Log("���ϑ̏d = " + avg);

        // ���K��� 3-18
        // weights�z��̒�����43�ȉ�������\������v���O����������Ă��������B
        for (int i = 0; i < weights.Length; i++)
        {
            if (weights[i] <= 43f)
            {
                Debug.Log(weights[i]);
            }
        }

        // �ǉ����
        // weights�z��̒��ɁA43�ȉ��̒l���������邩���J�E���g����v���O����������Ă��������B
        int cnt = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            if (weights[i] <= 43f)
            {
                cnt++;
                Debug.Log(weights[i]);
            }
        }
        Debug.Log("43�ȉ��̒l�̐� = " + cnt);

        // ���K���
        // 10��̃_���[�W�̒l�� 9,3,6,4,9,9,7,7,8,6 �̎��A���ς̃_���[�W���v�Z���ĕ\������
        // �v���O����������Ă��������B

        //�Q�����z��
        int[,] a = new int[2, 3];
        a[0, 0] = 1;
        a[0, 1] = 2;
        a[0, 2] = 3;
        a[1, 0] = 4;
        a[1, 1] = 5;
        a[1, 2] = 6;

        int[,] b = { { 10, 20, 30 }, { 40, 50, 60 } };

        // �Q�����z��̗v�f��
        Debug.Log(a.Length);        // 6
        Debug.Log(a.GetLength(0));  // 2
        Debug.Log(a.GetLength(1));  // 3

        for (int y= 0; y<2; y++)
        {
            for(int x=0; x<3; x++)
            {
                Debug.Log(a[y,x]);
            }
        }
    }

}
