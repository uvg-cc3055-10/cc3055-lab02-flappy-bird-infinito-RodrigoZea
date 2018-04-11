using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour {

    public float jumpForce = 200f;
    private Rigidbody2D rb;
    SpriteRenderer sr;
    public Sprite sp1, sp2, sp3;
    public Text gameOverTxt;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }
	
	void Update () {
        if (GameController.instance.gameOver == false)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * jumpForce);
                sr.sprite = sp2;
            }
            else
            {
                sr.sprite = sp1;    
            }
            
        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.instance.score++;
        Debug.Log("Score: " + GameController.instance.score);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.instance.gameOver= true;
        sr.sprite = sp3;
        gameOverTxt.enabled = true;
    }
}
