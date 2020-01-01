using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraScript : MonoBehaviour
{

    public float MouseSensitivity;
    public Transform PlayerBody;

    float XRotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float XAxis = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float YAxis = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        XRotation -= YAxis;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(XRotation, 0f, 0f);

        PlayerBody.Rotate(Vector3.up * XAxis);
    }
}
