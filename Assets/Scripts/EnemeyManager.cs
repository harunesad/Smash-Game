using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyManager : MonoBehaviour
{
    private Collision collision;
    private Rigidbody rb;
    private float enemySpeed = 2.0f;
    private GameObject playerObject;
    private bool isOnGround= true;
    void Start()
    {
        isOnGround = true;
        collision = GameObject.Find("Player").GetComponent<Collision>();
        rb = GetComponent<Rigidbody>();
        collision.point.text = "Point: " + collision.points;
        playerObject = GameObject.Find("Player");
    }
    void Update()
    {
        if (collision.points == 70)
        {
            collision.point.text = "Win Point: " + collision.points;
        }
        
    }
    private void FixedUpdate()
    {
        EnemyMove();
    }
    private void OnCollisionEnter(UnityEngine.Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            collision.points += 10;
            collision.point.text = "Point: " + collision.points;
            Debug.Log(collision.points);
            isOnGround = false;
        }
    }
    public void EnemyMove()
    {
        if (isOnGround == true)
        {
            Vector3 a = transform.position;
            Vector3 b = playerObject.transform.position;
            if (Mathf.Abs(transform.position.z) - Mathf.Abs(playerObject.transform.position.z) < 7
                && Mathf.Abs(transform.position.x) - Mathf.Abs(playerObject.transform.position.x) < 7)
            {
            transform.position = Vector3.Lerp(a, b, 0.02f);
            }
        }
        if (isOnGround == false)
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }
}
