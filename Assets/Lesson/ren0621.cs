//------------------------------------------------------------------------------
// �ȖځF�v���O���~���O�Z�@
// ���e�F���\�b�h�̊�{�p�^�[���R��
// �S���FKen.D.Ohishi 2024.06.21
//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ren0621 : MonoBehaviour
{
    void Start()
    {
        // func1 �����Ȃ��A�߂�l�Ȃ�
        func1();

        // func2 ��������A�߂�l�Ȃ�
        func2(100);

        // func3 ��������A�߂�l����
        string str = func3(100);
        Debug.Log(str);

        // ���P�D�ȉ��̎d�l�ʂ�A�����Ȃ��A�߂�l�Ȃ��̃��\�b�h���쐬���Ȃ����B
        // ���\�b�h���Fnkc
        // nkc���\�b�h�̏������e�F
        // �unkc���\�b�h�N��start���\�b�h�N����Ăяo���ꂽ�̂ŁA�W���[�X�𔃂��ɂ����܂����B�v
        // �ƕ\��
        // nkc(); // �Ăяo����

        // ���Q�D�ȉ��̎d�l�ʂ�A��������A�߂�l�Ȃ��̃��\�b�h���쐬���Ȃ����B
        // ���\�b�h���Fnkc2
        // nkc���\�b�h�̏������e�F
        // �unkc2���\�b�h�N��start���\�b�h�N����Z�~�n���ꂽ�̂ŁA�Z�Z�𔃂��ɂ����܂����B�v
        // �ƕ\���i�Z�͈����̒l�A�Z�Z�͈����̒l�ɉ��������i���O
        // �����F100 ���i�F��
        // �����F150 ���i�F����
        // �����F300 ���i�F�R�[�q�[
        // �����F690 ���i�F�o�i�i�u�������t���y�`�[�m
        // �Ăяo����
        // nkc2(100); // nkc2���\�b�h�N��start���\�b�h�N����100�~�n���ꂽ�̂ŁA���𔃂��ɂ����܂����B

        // ���R�D�ȉ��̎d�l�ʂ�A��������A�߂�l����̃��\�b�h���쐬���Ȃ����B
        // ���\�b�h���Fnkc3
        // nkc3���\�b�h�̏������e�F
        // �unkc3���\�b�h�N��start���\�b�h�N����Z�~�n���ꂽ�̂ŁA�Z�Z���X�^�[�g���\�b�h�ɖ߂��܂����v
        // �ƕ\���i�Z�͈����̒l�A�Z�Z�͈����̒l�ɉ��������i���O
        // �����F100 ���i�F��
        // �����F150 ���i�F����
        // �����F300 ���i�F�R�[�q�[
        // �����F690 ���i�F�o�i�i�u�������t���y�`�[�m
        // �Ăяo����
        // string str = nkc3(150);
        // Debug.Log(str); // nkc3���\�b�h�N��start���\�b�h�N����150�~�n���ꂽ�̂ŁA�������X�^�[�g���\�b�h�ɖ߂��܂���

        // ���3-19�D
        // �u���肪�Ƃ��������܂����v�ƕ\������Thankyou���\�b�h������Ă��������B

        // ���3-20�D
        // ������int�^�̐����l���󂯎��A���̒l�������Ȃ�u�����ł��v
        // ��Ȃ�u��ł��v�ƕ\������ShowEvenOrOdd���\�b�h������Ă�������

        // ���3-21�D
        // Shop���\�b�h�̏��i��500�~�̖��\��ǉ�
        // �܂��A�ȉ��ɖ򑐂ɑ����Ė��\����w�����閽�߂�ǉ�
        int money = 2500;
        Debug.Log("�������F" + money + "�~");
        int price = Shop("��");
        money -= price;
        Debug.Log("�������F" + money + "�~");

        // ���3-22.
        // int�^�̈������R�󂯎��A���̕��ϒl��float�^�ŕԂ�CalcAverage���\�b�h������Ă��������B
        // float avg = CalcAverage(90,80,60);
        // Debug.Log("����:" + avg);

    }

    // func1 �����Ȃ��A�߂�l�Ȃ�
    void func1()
    {
        Debug.Log("�����Ȃ��A�߂�l�Ȃ��̃��\�b�h");
    }

    // func2 ��������A�߂�l�Ȃ�
    void func2(int a)
    {
        Debug.Log("����:" + a + " �߂�l�Ȃ��̃��\�b�h");
    }

    // func3 ��������A�߂�l����
    string func3(int a)
    {
        string result = "";
        if(a >= 1000)
        {
            result = "start���\�b�h���A1000�ȏ�̒l���󂯎��܂����B";
        }
        else
        {
            result = "start���\�b�h���A1000�����̒l���󂯎��܂����B";
        }
        return result;
    }

    // List 3-20 �V���b�v���\�b�h
    int Shop(string itemName)
    {
        int price = 0;

        if(itemName == "��")
        {
            Debug.Log(itemName + "��100�~�ł�");
            price = 100;
        }
        else if (itemName == "���_")
        {
            Debug.Log(itemName + "��1500�~�ł�");
            price = 1500;
        }
        else
        {
            Debug.Log(itemName + "�͂���܂���");
            price = 0;
        }
        return price;
    }
}
