using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuangShouJianAbility : BaseAbility
{
    private CharacterController CC;
    private LineRenderer LR;

    public float heroLevel;

    public Transform hookBody;
    private float coolDownStartTimeQ;
    private bool allowQ = true;
    public float skillQCoolDownTime;
    public float hookLength = 5;

    // Start is called before the first frame update
    void Start()
    {
        CC = GetComponent<CharacterController>();
        LR = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        heroLevel = GetComponent<PlayerStats>().level;

        if (Input.GetKeyDown(KeyCode.Q) && allowQ)
		{
            // Draw the hook line        
            LR.positionCount = 2;
            LR.SetPosition(0, hookBody.position);
            LR.SetPosition(1, hookBody.position + transform.forward * hookLength * heroLevel);

           /* LR.startColor = Color.blue;
            LR.endColor = Color.blue;*/

            Invoke("DisableLineRenderer", 1);

            // Set the condition when hook an object
            if (true)
			{
                Invoke("MoveWithHook", 1);
            }

            coolDownStartTimeQ = Time.time;
            allowQ = false;
		}

		if (Time.time - coolDownStartTimeQ >= skillQCoolDownTime)
		{
            allowQ = true;
        }
    }

    private void DisableLineRenderer()
    {
        LR.positionCount = 0;
    }
    private void MoveWithHook()
    {
        CC.Move(transform.forward * hookLength);
    }
}
