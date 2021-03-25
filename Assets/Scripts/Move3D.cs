using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3D : MonoBehaviour
{
    private Rigidbody Rigidbody;

    private float hAxis;
    private float vAxis;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
		{
            Rigidbody.AddForce(Vector3.up * speed * Time.deltaTime);
		}

		Rigidbody.AddForce(Vector3.forward * vAxis * speed * Time.deltaTime);
		Rigidbody.AddForce(Vector3.right * hAxis * speed * Time.deltaTime);
	}
}
