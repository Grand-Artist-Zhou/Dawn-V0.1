using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameSceneManager : MonoBehaviour
{
	public static bool isInMenu = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		LoadPauseMenu();
	}

	private static void LoadPauseMenu()
	{
		if (!isInMenu)
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				SceneManager.LoadScene("Pause Menu", LoadSceneMode.Additive);

				isInMenu = true;
			}
		}
		else
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				SceneManager.UnloadSceneAsync("Pause Menu");

				isInMenu = false;
			}
		}
	}
}
