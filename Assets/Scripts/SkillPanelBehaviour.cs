using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPanelBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		for (int i = 0; i < 5; i++)
		{
            transform.GetChild(i).GetChild(1).GetComponent<Image>().sprite =
                GameObject.FindGameObjectWithTag("Player")
                .transform.GetChild(0).GetComponent<HeroAssets>().UIAssets[i];
        }
    }
}
