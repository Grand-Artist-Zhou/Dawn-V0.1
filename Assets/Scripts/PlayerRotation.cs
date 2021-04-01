using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public Transform cameraBody;

    public float mouseSensitivity = 100;

    private float xRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float z = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        transform.Rotate(x * Vector3.up);

        xRotation -= z;

        xRotation = Mathf.Clamp(xRotation, -90, 90);
        cameraBody.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }
}
