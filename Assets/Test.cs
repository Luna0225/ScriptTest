using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    //bossメンバ変数の宣言
    private int hp = 100;
    private int power = 50;
    //midbossのメンバ変数の宣言
    private int newVariable1 = 50;
    private int newVariable2 = 25;
    //メンバ関数の宣言
    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
        
    }
    public void Attack2()
    {
        Debug.Log(this.newVariable2 + "のダメージを与えた");
    }
    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        
        //残りHPを減らす
        this.hp -= damage;
        this.newVariable1 -= damage;
    }
    //bossメンバ変数の宣言
    private int mp = 53;
    //魔法用の関数
    public void Magic(int magic)
    {
        if (mp > 4)
        {
            this.mp -= magic;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない");
        }
        
        
            
        
    }
}
    


public class Test : MonoBehaviour
{
    void Start()
    {
        //Bossクラスの変数を宣言してインスタンスに代入
        Boss lastboss = new Boss ();

        //攻撃用の変数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法用の関数を10回呼び出す
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(5);
        }


        Boss midboss = new Boss ();
        //攻撃用の関数
        midboss.Attack2();
        //防御用の関数
        midboss.Defence(4);
        //Start2関数を呼び出す
        Start2();
    }

    void Start2()
    {
        //配列の初期化
        int[] points = { 10, 20, 30, 40, 50 };
        //配列の要素の分だけ繰り返す
        for (int i = 0; i < points.Length; i++)
        {
            //配列の要素を表示する
            Debug.Log(points[i]);
        }
        //配列の初期化
        int[] points1 = { 10, 20, 30, 40, 50 };
        //配列の要素の分だけ逆から繰り返す
        for (int d = 4; d < points1.Length; d--)
        {
            if(d<0)
            {
                break; //処理を止める
            }
 
                Debug.Log(points1[d]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}