using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    //boss�����o�ϐ��̐錾
    private int hp = 100;
    private int power = 50;
    //midboss�̃����o�ϐ��̐錾
    private int newVariable1 = 50;
    private int newVariable2 = 25;
    //�����o�֐��̐錾
    //�U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
        
    }
    public void Attack2()
    {
        Debug.Log(this.newVariable2 + "�̃_���[�W��^����");
    }
    //�h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        
        //�c��HP�����炷
        this.hp -= damage;
        this.newVariable1 -= damage;
    }
    //boss�����o�ϐ��̐錾
    private int mp = 53;
    //���@�p�̊֐�
    public void Magic(int magic)
    {
        if (mp > 4)
        {
            this.mp -= magic;
            Debug.Log("���@�U���������B�c��MP��" + mp);
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
        }
        
        
            
        
    }
}
    


public class Test : MonoBehaviour
{
    void Start()
    {
        //Boss�N���X�̕ϐ���錾���ăC���X�^���X�ɑ��
        Boss lastboss = new Boss ();

        //�U���p�̕ϐ����Ăяo��
        lastboss.Attack();
        //�h��p�̊֐����Ăяo��
        lastboss.Defence(3);
        //���@�p�̊֐���10��Ăяo��
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(5);
        }


        Boss midboss = new Boss ();
        //�U���p�̊֐�
        midboss.Attack2();
        //�h��p�̊֐�
        midboss.Defence(4);
        //Start2�֐����Ăяo��
        Start2();
    }

    void Start2()
    {
        //�z��̏�����
        int[] points = { 10, 20, 30, 40, 50 };
        //�z��̗v�f�̕������J��Ԃ�
        for (int i = 0; i < points.Length; i++)
        {
            //�z��̗v�f��\������
            Debug.Log(points[i]);
        }
        //�z��̏�����
        int[] points1 = { 10, 20, 30, 40, 50 };
        //�z��̗v�f�̕������t����J��Ԃ�
        for (int d = 4; d < points1.Length; d--)
        {
            if(d<0)
            {
                break; //�������~�߂�
            }
 
                Debug.Log(points1[d]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}