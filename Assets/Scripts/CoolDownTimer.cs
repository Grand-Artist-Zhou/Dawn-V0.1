using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolDownTimer : MonoBehaviour
{
    public Text timeText;

    private float timeRemaining;
    private float cdCycle;
    public bool timerIsRunning = false;
    private string skillName;

    private void Start()
    {
        timerIsRunning = true;
        skillName = GetComponentInParent<Transform>().GetComponentInParent<Transform>().name;
		if (name == "SkillQ")
		{
            cdCycle = GameObject.FindGameObjectWithTag("Player").GetComponent<BaseAbility>().SkillQCD;
            Debug.Log(cdCycle);
		}
		else if (name == "SkillW")
		{
            cdCycle = GameObject.FindGameObjectWithTag("Player").GetComponent<BaseAbility>().SkillWCD;
        }
        else if (name == "SkillE")
        {
            cdCycle = GameObject.FindGameObjectWithTag("Player").GetComponent<BaseAbility>().SkillECD;
        }
        else if (name == "SkillR")
        {
            cdCycle = GameObject.FindGameObjectWithTag("Player").GetComponent<BaseAbility>().SkillRCD;
        }
        else if (name == "SkillUlt")
        {
            cdCycle = GameObject.FindGameObjectWithTag("Player").GetComponent<BaseAbility>().SkillUltCD;
        }
        timeRemaining = cdCycle;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = cdCycle;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = seconds.ToString();
    }
}
