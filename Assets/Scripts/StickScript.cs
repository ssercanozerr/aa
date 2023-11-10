using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float stickSpeed;
    bool isMovementRestricted = false;
    public GameObject gameManager;
    public static bool gameOver = false;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isMovementRestricted == false)
        {
            rb.MovePosition(rb.position + Vector2.up * stickSpeed * Time.deltaTime);
        }        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RotatingCircle")
        {
            transform.SetParent(collision.transform);
            isMovementRestricted = true;
        }

        if (collision.gameObject.tag == "SmallCircle")
        {
            gameManager.GetComponent<GameOverScript>().GameOver();
            gameOver = true;
        }
    }
}
