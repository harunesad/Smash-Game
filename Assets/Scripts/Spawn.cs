using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    private Vector3 pos;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            pos.x = Random.Range(-6.5f, 6.5f);
            pos.y = 0;
            pos.z = Random.Range(-6.5f, 6.5f);

            prefab = Instantiate(prefab, pos, Quaternion.identity) as GameObject;
        }
    }
}
