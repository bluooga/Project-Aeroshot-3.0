using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOptions : MonoBehaviour
{   
    public static float MouseSensitivity;
    public static float CameraFOV;

    private void Start()
    {
        if(MouseSensitivity <= 0)
        {
            MouseSensitivity = 100;
        }
        if(CameraFOV <= 0)
        {
            CameraFOV = 100;
        }

        Camera.main.fieldOfView = CameraFOV;

    }

    public void changeSensitivity(float Sensitivity)
    {
        MouseSensitivity = Sensitivity;
    }

    public void changeFOV(float FOV)
    {
        CameraFOV = FOV;
        Camera.main.fieldOfView = CameraFOV;
    }
}
