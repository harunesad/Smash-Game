using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, -7);
    void Start()
    {
        transform.Rotate(30, 0, 0);
    }
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
