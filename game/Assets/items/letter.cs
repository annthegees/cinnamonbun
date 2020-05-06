using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letter : MonoBehaviour
{
    public new GameObject gameObject;
    void OnMouseDown()
    {
        Debug.Log("Предмет взят.");
        transform.position = new Vector3(-10f, -2f, 0f);
        gameObject.GetComponent<inventory>().Add(3);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
