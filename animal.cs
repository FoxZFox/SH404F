using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animal : MonoBehaviour
{

    protected string characterName; //this is a Name of animal
    protected float moveSpeed = 1.0f;//this is a MoveSpeed U know ?
    protected float jumpForce;//and this is a jump power u know ?
    int lives;

    Vector3 startPosition; // this is a Animal Position

    // Use this for initialization
    void Start()
    {
        print("If you want us to move around, make sure you've remove // in animal's script.");
        Init();
    }

    protected virtual void Init()
    {
        lives = 3;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public virtual void Move()
    {
        Vector3 newPosition = startPosition + Vector3.zero * moveSpeed * Mathf.Sin(Time.time);//ประกาศตัวแปร newPosition เพื่อให้เกิดการเคลื่อนที่แบบโครตจะมั่วเพราะงั้นปรับตรง "Vector3.xxxx" เป็น zero แหละดีสุด 
        //Jump code
        jumpForce -= 14 * Time.deltaTime;//i dont know this but i think this is a แรงโน้มถ่วง

        if (jumpForce < 0)
        {
            jumpForce = 0;
        }
        newPosition.y = startPosition.y + jumpForce;
        //Jump code
        transform.position = newPosition;
    }
    public virtual void Talk() //คำพูดเวลากด talk อยากให้กวนตีนหน่อยก็ตอบว่า **** U
    {
        print(characterName + " I can't talk!");
        print(characterName + " has " + lives + " lives");
        print(characterName + " move speed = " + moveSpeed);
    }
    public virtual void Jump()
    {
        jumpForce = 2.0f; //แรงกระโดด
    }
}