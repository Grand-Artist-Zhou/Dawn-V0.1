using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAbility : MonoBehaviour
{
    public float SkillQCD;
    public float SkillWCD;
    public float SkillECD;
    public float SkillRCD;
    public float SkillUltCD;

    public float StartTimeQ;
    public float StartTimeW;
    public float StartTimeE;
    public float StartTimeR;
    public float StartTimeUlt;

    public bool allowQ = true;
    public bool allowW = true;
    public bool allowE = true;
    public bool allowR = true;
    public bool allowUlt = true;
}
