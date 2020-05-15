
using UnityEngine;
using UnityEngine.UI;

public class triggerbutton : MonoBehaviour
{
    public Button butt;
    public void OnTriggerStay2D(Collider2D collision)
    {
        butt.enabled = true;
    }
    public void OnTriggerExit2D (Collider2D collision)
    {
        butt.enabled = false;
    }
    // Start is called before the first frame update
    
}
