using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gilza : MonoBehaviour
{
    public new GameObject gameObject;
    void OnMouseDown()
    {
        Debug.Log("Предмет взят.");
        transform.position = new Vector3(-10f, -2f, 0f);
        gameObject.GetComponent<inventory>().Add(2);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Mouse down");
        //other.attachedRigidbody.AddForce(-0.1F * other.attachedRigidbody.velocity);
        // if (other.attachedRigidbody)
        // other.attachedRigidbody.AddForce(Vector3.up * 10);
    }
}

