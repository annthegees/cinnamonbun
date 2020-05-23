using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class singer : MonoBehaviour
{
    public Button startdia;
    // Start is called before the first frame update
    void Start()
    {
        //startdia.enabled = false;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        startdia.enabled = true;
        Debug.Log("hg");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
