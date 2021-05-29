using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanShouJianAbility : BaseAbility
{
    private CharacterController cc;
    private LineRenderer lr;
	private PlayerStats ps;

	//public Transform hookBody;
	public float hookLength = 5;
	public Transform hookBody;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        lr = GetComponent<LineRenderer>();
		ps = GetComponent<PlayerStats>();
	}

    // Update is called once per frame
    void Update()
	{
		UseSkillQ();
		UseSkillE();
	}

	// Ability Q
	private void UseSkillQ()
	{
		if (Input.GetKeyDown(KeyCode.Q) && allowQ)
		{
			float heroLevel = ps.level;

			// Draw the hook line        
			lr.positionCount = 2;
			lr.SetPosition(0, hookBody.position);
			lr.SetPosition(1, hookBody.position + transform.forward * hookLength * heroLevel);

			/* LR.startColor = Color.blue;
			 LR.endColor = Color.blue;*/

			Invoke("DisableLineRenderer", 1);

			// Set the condition when hook an object
			if (true)
			{
				Invoke("MoveWithHook", 1);
			}

			StartTimeQ = Time.time;
			allowQ = false;
		}

		if (!allowQ && Time.time - StartTimeQ >= SkillQCD)
		{
			allowQ = true;
		}
	}

	// Ability E
	private void UseSkillE()
	{
		if (Input.GetKeyDown(KeyCode.E) && allowE)
		{
			float heroLevel = ps.level;



			StartTimeE = Time.time;
			allowE = false;
		}

		if (!allowE && Time.time - StartTimeE >= SkillECD)
		{
			allowE = true;
		}
	}

	//-----------------------------------------------------------------------------------//
	//-----------------------------------------------------------------------------------//
	//------------------------------------ Helper methods -------------------------------//
	//-----------------------------------------------------------------------------------//
	//-----------------------------------------------------------------------------------//

	private void DisableLineRenderer()
    {
        lr.positionCount = 0;
    }
    private void MoveWithHook()
    {
        cc.Move(transform.forward * hookLength);
    }
}
