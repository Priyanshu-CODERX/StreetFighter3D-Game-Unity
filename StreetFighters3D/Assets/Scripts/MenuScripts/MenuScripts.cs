using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{
    public void instructions(){
    	SceneManager.LoadScene("instructions");
    }

    public void loadMainMenu(){
    	SceneManager.LoadScene("StartMenu");
    }

    public void loadCredits(){
    	SceneManager.LoadScene("credits");
    }

    public void loadGame(){
    	SceneManager.LoadScene("MainLevel");
    }

    public void quit(){
    	Application.Quit();
    }
}
