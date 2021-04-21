using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    PlayerStats PS;

    // Start is called before the first frame update
    void Start()
    {
        PS = GetComponent<PlayerStats>();
    }

	private void OnTriggerEnter(Collider other)
	{
        PS.health -= other.GetComponent<PlayerStats>().damage * PS.armor;
    }
}
