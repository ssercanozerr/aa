using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverAnimationScript : MonoBehaviour
{
    Animator animator;
    public GameObject panel;
    void Start()
    {
        animator= GetComponent<Animator>();
    }

    void Update()
    {
        if (StickScript.gameOver == true)
        {
            animator.SetBool("GameOver", true);
            panel.SetActive(true);
        }
    }
}
