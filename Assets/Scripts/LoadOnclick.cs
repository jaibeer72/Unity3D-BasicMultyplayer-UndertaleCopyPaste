using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadOnclick : MonoBehaviour {

	// Use this for initialization
	public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadSceneAsync(sceneIndex);
    }
    public void QuitGame()
    {
        Application.Quit(); 
    }
}
