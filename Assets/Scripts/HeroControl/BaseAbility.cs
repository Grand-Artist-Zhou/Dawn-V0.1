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

    protected float StartTimeQ;
    protected float StartTimeW;
    protected float StartTimeE;
    protected float StartTimeR;
    protected float StartTimeUlt;

    public bool allowQ = true;
    public bool allowW = true;
    public bool allowE = true;
    public bool allowR = true;
    public bool allowUlt = true;
}
