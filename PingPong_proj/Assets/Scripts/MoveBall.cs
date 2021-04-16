using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBall : MonoBehaviour
{
    public Rigidbody2D ballRb;
    public Transform ball;
    public SpriteRenderer spriteBall;
    public float ballSpeed = 5;
    public Vector2 direction;
    public Text textScore;
    public Text textRecord;
    int score = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Racket"))
        {
            direction.y = -direction.y;
            score++;
        }
        if (collision.gameObject.CompareTag("Border"))
        { 
            Lose();
        }
        if (collision.gameObject.CompareTag("Wall"))
            direction.x = -direction.x;
    }
    void Lose (){
        if (PlayerPrefs.GetInt("Record") < score) {
            PlayerPrefs.SetInt("Record", score);
        }
        PlayerPrefs.Save();
        score = 0;
        NewGame();
    }
    void NewGame()
    {
        ball.position = new Vector3(0f, 0f, 0f);
        direction = new Vector2(Random.Range(-0.5f, 1f), Random.Range(-0.5f, 1f));
        ballSpeed = Random.Range(7f, 12f);
        float ballScale = Random.Range(0.1f, 1f);
        ball.localScale = new Vector3(ballScale, ballScale, 1);
    }
    void Start()
    {
        if(PlayerPrefs.GetInt("Color") == 1)
        {
            spriteBall.color = new Color32(131,255,0,255);
        }
        else if(PlayerPrefs.GetInt("Color") == 3) {
            spriteBall.color = new Color32(244,0,255,255);
        }
        else
        {
            spriteBall.color = new Color32(255,255,255,255);
        }
        NewGame();
    }
    void Update()
    {
        ballRb.velocity = direction.normalized * ballSpeed;
        textScore.text = score.ToString();
        textRecord.text = PlayerPrefs.GetInt("Record").ToString();
    }
}
