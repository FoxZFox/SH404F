using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //เรียกใช้ Ui

public class GamePlayManager : MonoBehaviour
{

    int score = 0; //คะแนนตั้งต้น
    public Text Scoretext;//กระดานคะแนน ต้องเปิดใช้งาน UnityEngine.UI เสมอ
    int sumscore; //รวมคะแนน
    // Start is called before the first frame update
    void Start()
    {
        Updatescore(score); //ใช้งาน Void Updatescore ตอนเปิดเกม
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Updatescore(int score) //ไว้อัพเดทคะแนน
    {
        sumscore += score;//รวมคะแนน
        Scoretext.text = "Score : " + sumscore;//um this is a การ calling กระดานของ Text แล้ว Update Score นะคะ
    }
}
