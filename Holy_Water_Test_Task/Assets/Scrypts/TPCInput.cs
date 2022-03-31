using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class TPCInput : MonoBehaviour
{
    public FixedJoystick muveJoystick;
    public FixedJoystick cameraJoystick;
    protected ThirdPersonUserControl Control;

    protected float cameraAngle;
    protected float cameraAngleSpeed = 2f;

    private void Start()
    {
        Control = GetComponent<ThirdPersonUserControl>();
    }

    private void Update()
    {
        Control.RunAxis = muveJoystick.Direction;
        cameraAngle += cameraJoystick.Direction.x * cameraAngleSpeed;
        Camera.main.transform.position = transform.position + Quaternion.AngleAxis(cameraAngle, Vector3.up) * new Vector3(0, 3, -4);
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position, Vector3.up);   
    }
}
