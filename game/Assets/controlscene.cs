using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlscene : MonoBehaviour
{
   public string startLevel;

    public void NewGame()
    {
        Application.LoadLevel (startLevel);
    }
}
