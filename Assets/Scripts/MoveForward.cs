using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveForward : MonoBehaviour
{
    public float speed = 6;
    public float pos = 13.25f;
    private Animator animator;
    public Text gameOver;
    public bool onGround = true;
    private Rigidbody rigid;
    void Start()
    {
        animator = GameObject.Find("Ch43_nonPBR@Slow Run").GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Forward();
    }
    public void Forward()
    {
        if (onGround == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
    private void OnCollisionEnter(UnityEngine.Collision collisions)
    {
        if (collisions.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("Running", false);
            gameOver.text = "Game Over";
            onGround = false;
        }
    }
}
