using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class ThirdPersonInput : MonoBehaviour
{
    public FixedJoystick LeftJoystick;
    public FixedTouchField TouchField;

    protected ThirdPersonUserControl Control;

    protected float CameraAngle;
    protected float CameraAngleSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        Control = GetComponent<ThirdPersonUserControl>();
    }

    // Update is called once per frame
    void Update()
    {
        Control.Hinput = LeftJoystick.input.x;
        Control.Vinput = LeftJoystick.input.y;

        //swipe kamera (rotasi)
        CameraAngle += TouchField.TouchDist.x * CameraAngleSpeed;

        //follow player camera
        Camera.main.transform.position = 
            transform.position + Quaternion.AngleAxis(CameraAngle, Vector3.up) * new Vector3(0, 4, -4);

        Camera.main.transform.rotation = 
            Quaternion.LookRotation(transform.position + Vector3.up *2f - Camera.main.transform.position, Vector3.up);
    }
}
