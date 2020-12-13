using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
	private string sceneLoad = "MainLevel";
    public void PlayGame() {
    	SceneManager.LoadScene(sceneLoad);
    }

    public void QuitGame() {
    	Debug.Log("QUITTING GAME");
    	Application.Quit();
    }

}
