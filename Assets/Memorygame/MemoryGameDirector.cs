using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MemoryGameDirector : MonoBehaviour
{
    public GameObject cardPre;                  // �J�[�h�̃v���n�u���Z�b�g
    public GameObject resultText;               // ���ʂ�\������e�L�X�g
    public Text timeText;                       // ���Ԃ�\������e�L�X�g
    float timeCount;                            // �o�ߎ���
    bool timeFlg;                               // ���ԃt���O
    int lastCardCnt;                            // �J�[�h�̎c�薇��
    int clickCnt;                               // �N���b�N���J�E���g�p

    GameObject[] cards = new GameObject[10];    // �J�[�h�̃Q�[���I�u�W�F�N�g��ۑ�����ϐ�
    GameObject[] checkCard = new GameObject[2]; // ����p�̕ϐ�

    // �J�[�h�ԍ��e�[�u���i��ŃV���b�t������j
    int[] cardNumber = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4 };

    void Start()
    {
        clickCnt    = 0;    // �N���b�N��
        lastCardCnt = 10;   // �J�[�h�̎c�薇��
        timeCount = 0f;     // �o�ߎ���
        timeFlg = false;   // ���ԊJ�n�t���O

        // �J�[�h�ԍ����V���b�t������
        for (int i= cardNumber.Length - 1; i>0; i--)
        {
            int j = Random.Range(0, i + 1);
            int k = cardNumber[i];
            cardNumber[i] = cardNumber[j];
            cardNumber[j] = k;
        }

        // �V���b�t����̃J�[�h�z����m�F�i�f�o�b�O�p�j
        //for (int i = 0; i < cardNumber.Length; i++)
        //{
        //    Debug.Log(cardNumber[i]);
        //}

        // �J�[�h�����T�A�c�Q�ɕ��ׂ�
        Vector3 offset   = new Vector3(-2.5f, -0.5f, 0);    // �����̃J�[�h�̍��W
        Vector3 interval = new Vector3(1.5f, 2f, 0);        // �z�u�̊Ԋu
        for (int y = 0; y < 2; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                // �J�E���g�ϐ��𗘗p���āA�J�[�h�̔z�u���W������
                Vector3 pos = new Vector3(interval.x * x, interval.y * y, 0) + offset;

                // 0,1,2,3,4,0,1,2,3,4 �� 0,1,2,3,4,5,6,7,8,9 �ɂ���v�Z��
                int n = x + y * 5;

                // �v���n�u����C���X�^���X�𐶐����Ĕz�u
                cards[n] = Instantiate(cardPre, pos, Quaternion.identity);

                // �R���|�[�l���g���擾����cardNumber�̒l���Z�b�g
                MemoryGameCardController mgcc = cards[n].GetComponent<MemoryGameCardController>();
                mgcc.cardNumber = cardNumber[n];
            }
        }

        // ���ʕ\���p�e�L�X�g���A�N�e�B�u�ɂ���
        resultText.SetActive(false);
    }

    void Update()
    {
        // �}�E�X���N���b�N���ꂽ�u��
        if(Input.GetMouseButtonDown(0))
        {
            // �J��������N���b�N�ʒu�Ƀ��[�U�[�r�[���𔭎ˁI�I
            Vector2 rayPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero);

            // ���[�U�[�r�[�����Q�[���I�u�W�F�N�g�Ƀq�b�g�I�I
            if(hit.collider != null && clickCnt < 2)
            {
                timeFlg = true;    // �ŏ��̃J�[�h���J���ꂽ���_�ŃX�^�[�g

                // �N���b�N���ꂽ�J�[�h�� checkCard �ɕۑ�
                checkCard[clickCnt] = hit.collider.gameObject;
                MemoryGameCardController mgcc = checkCard[clickCnt].GetComponent<MemoryGameCardController>();

                // click����Ă��Ȃ��J�[�h��������N���b�N�J�E���g�𑝂₷
                if(mgcc.isClick == false)
                {
                    clickCnt++; // �N���b�N�J�E���g�𑝂₷
                }

                // �J�[�h��click�t���O��ON�ɂ���
                mgcc.isClick = true;
            }
        }

        // ����͉E�N���b�N
        if (Input.GetMouseButtonDown(1))
        {
            // �N���b�N�J�E���g���Q��菬�������͔��肵�Ȃ�
            if(clickCnt < 2) return;

            // �I�����ꂽ�J�[�h��MemoryGameCardController�R���|�[�l���g���擾
            MemoryGameCardController mgcc1 = checkCard[0].GetComponent<MemoryGameCardController>();
            MemoryGameCardController mgcc2 = checkCard[1].GetComponent<MemoryGameCardController>();

            // �I�������Q���̃J�[�h�������F���ǂ����𔻒�
            if(mgcc1.cardNumber == mgcc2.cardNumber)
            {
                // �N���b�N���ꂽ�Q���̃J�[�h�������ԍ��i�F�j�Ȃ����
                Destroy(checkCard[0]);
                Destroy(checkCard[1]);
                lastCardCnt -= 2;   // �J�[�h�̎c�薇�������炷
            }
            else
            {
                // �N���b�N���ꂽ�Q���̃J�[�h���Ⴄ�ԍ��Ȃ�N���b�N�t���O��OFF�ɂ���
                mgcc1.isClick = false;
                mgcc2.isClick = false;
            }

            // �N���b�N�J�E���g��������
            clickCnt = 0;
        }

        // �o�ߎ��ԑ���
        if(timeFlg)
        {
            // ���Ԃ����Z���A�\���ɔ��f
            timeCount += Time.deltaTime;
            timeText.text = "Time " + timeCount.ToString("F2") + "�b";
        }

        // �N���A����
        if(lastCardCnt == 0)
        {
            // �N���A�̕\��
            resultText.SetActive(true);

            // ���Ԍo�ߒ�~
            timeFlg = false;

            // �V�[���������[�h
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("GameScene");
            }
        }
    }
}
