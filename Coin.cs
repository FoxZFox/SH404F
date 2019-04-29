using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour //ตัวแปรใช้เพิ่มคะแนน
{

    GamePlayManager gameplaymanager;
    int score = 10; //คะแนน
    // Start is called before the first frame update
    void Start()
    {
        gameplaymanager = GameObject.FindObjectOfType<GamePlayManager>(); //ตั้งค่า Object ของตัวแปลกลาง
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)//Void บังคับในการทำ Hitboxเหรียญ
    {
        gameplaymanager.Updatescore(score); //เพิ่มคะแนน
        gameObject.GetComponent<Renderer>().enabled = false; //ชนบล็อคแล้วบล็อคหาย
        gameObject.GetComponent<BoxCollider2D>().enabled = false; //ปิดการทำงาน HitBox
        Debug.Log("OnCollisionEnter2D");
    }


}
