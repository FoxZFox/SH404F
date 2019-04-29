using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : animal //แมวเหมียวเปลี่ยนไปใช้อย่างอื่นได้ แพทเทิ่ลเดียวกัน
{
    public override void Talk()
    {
        //base.Talk();
        print("Meow*");
        print("I am " + characterName);
        print("I love running around");
    }
    protected override void Init()
    {
        base.Init();
        characterName = "Groofy";
        moveSpeed = 1.0f;
    }

    public override void Move()
    {
        //transform.position += Vector3.right * moveSpeed * Mathf.Cos(Time.time);
        base.Move();
    }
    public override void Jump()
    {
        jumpForce = 5.0f;
    }
}
