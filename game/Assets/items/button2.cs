using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour
{
    public GameObject detective;
    void Update()
    {

    }
    public void SetPosition()
    {
        transform.position = new Vector3(30f, 0f, -9.948102f);
        detective.transform.position = new Vector3(37f, -5f, 0f);
    }
}
