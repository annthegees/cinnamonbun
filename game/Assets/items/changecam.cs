using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecam : MonoBehaviour
{
    public GameObject detective;
    void Start()
    {
        transform.position = new Vector3(0.2293153f, 0f, -10.07727f);
        detective.transform.position = new Vector3(7f, -5f, 0f);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            transform.position = new Vector3(0.2293153f, 0f, -10.07727f);
            detective.transform.position = new Vector3(7f, -5f, 0f);

        }
        if (Input.GetKey(KeyCode.B))
        {
            transform.position = new Vector3(-0.01f, 20.25f, -9.948102f);
            detective.transform.position = new Vector3(7.5f, 16f, 0f);
        }
    }
}
