using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    private float scale = 0.1f;
    private MoveForward forward;
    public Text point, coin;
    public int coins = 0;
    public int points = 0;
    private Rigidbody rigidBody;
    void Start()
    {
        forward = gameObject.GetComponent<MoveForward>();
        coin.text = "Coin: " + coins;
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {

    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            Destroy(collision.gameObject);
            transform.localScale = transform.localScale + new Vector3(scale, scale, scale);
            rigidBody.mass += 0.1f;

            coins += 10;
            coin.text = "Coin: " + coins;
        }
    }
}
