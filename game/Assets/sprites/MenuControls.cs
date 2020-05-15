using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


        public class MenuControls : MonoBehaviour

{
    
 
        public void PlayPressed()

    {

        SceneManager.LoadScene("Scenes/game");

    }

    public void ExitPressed()

    {

        Debug.Log("Exit pressed!");
        Application.Quit();

        
    }
    
        
    
}
