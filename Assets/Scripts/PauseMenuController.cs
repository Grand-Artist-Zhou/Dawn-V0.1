using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public void ChangeBackToScene()
    {
        InGameSceneManager.isInMenu = false;

        Time.timeScale = 1;

        SceneManager.UnloadSceneAsync("Pause Menu");
    }

	private void Start()
	{
        Time.timeScale = .5f;
    }
}
