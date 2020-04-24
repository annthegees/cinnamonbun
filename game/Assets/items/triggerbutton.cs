using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class triggerbutton : MonoBehaviour
{
    public Button butt;
    public void OnTriggerStay2D(Collider2D collision)
    {
        butt.SetEnabled(true);
    }
    public void OnTriggerExit2D (Collider2D collision)
    {
        butt.SetEnabled(false);
    }
    // Start is called before the first frame update
    
}
