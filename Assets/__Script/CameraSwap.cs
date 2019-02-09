using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public Vector3 Position1 = new Vector3(0.1f,6.5f,-12.5f);
    public Vector3 Position2 = new Vector3(0, 11f, 0);
    public static Vector3 RotationVec1 = new Vector3(20f, 0, 0);
    public static Vector3 RotationVec2 = new Vector3(90f, 0, 0);
    public Quaternion Rotation1 = Quaternion.Euler(RotationVec1);
    public Quaternion Rotation2 = Quaternion.Euler(RotationVec2);

    //Start Init
    void Start()
    {
    }
    void Update()   
    {
        //Change Camera Keyboard
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (gameObject.transform.position == Position1)
            {
                gameObject.transform.position = Position2;
                gameObject.transform.rotation = Rotation2;   
            }
            else
            {
                gameObject.transform.position = Position1;
                gameObject.transform.rotation = Rotation1;
            }
        }
    }
}