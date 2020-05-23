using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject detective;
    public GameObject helper;
    void Update()
    {
        
    }
    public void SetPosition ()
    {
        transform.position = new Vector3(-0.01f, 20.25f, -9.948102f);
        detective.transform.position = new Vector3(7.5f, 16f, 0f);
        helper.transform.position = new Vector3(7f, 16f, 0f);
    }
}
