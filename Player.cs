using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text ScoreText;
    public Text HealthText;
    public Text LivesText;
    string playerName;
    float speed;
    int health, lives, maxHealth, maxLives, score, damage;

    // Start is called before the first frame update
    void Start()
    {
        playerName = "Tori";
        maxHealth = 50;
        maxLives = 3;
        health = maxHealth;
        lives = maxLives;
        score = 0;
        damage = 10;
        speed = 5.0f;

        UpdateScoreText();
        UpdateHealthText();
        UpdateLivesText();
    }

    // Update is called once per frame
    
    void Update()
    {
        Move();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        if(Input.GetMouseButtonDown(0))
        {
           
            AddScore();
            UpdateScoreText();

            //print("Score : " + score);
        }
        if (Input.GetMouseButtonDown(1))
        {
            int ranDamage = Random.Range(10, 21);
            print("Random Damage : " + ranDamage);
            TakeDamageWithParam(ranDamage);

            //TakeDamage();
            UpdateHealthText();
        }
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
    void Shoot()
    {
        print("Shoot!");
        print("Shoot!");
        print("Shoot!");
    }
    void AddScore()
    {
        score += 1;
    }
    void UpdateScoreText()
    {
        ScoreText.text = "score : " + score;
    }
    void UpdateHealthText()
    {
        HealthText.text = "HP : " + health;
    }
    void UpdateLivesText()
    {
        LivesText.text = "Lives : " + lives;
    }
    void TakeDamage()
    {
        health -= damage;  
        if(health <= 0)
        {
            lives -= 1;
            UpdateLivesText();
            health = maxHealth;
        }
    }
    void TakeDamageWithParam(int ranDamage)
    {
        health -= ranDamage;
        if (health <= 0)
        {
            lives -= 1;
            UpdateLivesText();
            health = maxHealth;
        }
    }


}
