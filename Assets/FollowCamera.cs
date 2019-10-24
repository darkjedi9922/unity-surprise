using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player;
    public float ceilRotateValue = -75;
    public float floorRotateValue = 75;
    
    private WhitePlayer white;
    private float fixedPosY;
    
    private float fixedRotX;
    private float fixedRotZ;

    void Start()
    {
        fixedPosY = transform.position.y;
        fixedRotX = transform.rotation.eulerAngles.x;
        fixedRotZ = transform.rotation.eulerAngles.z;

        white = player.GetComponent<WhitePlayer>();
    }

    void Update()
    {
        if (white.isDied()) {
            transform.parent = null;
            return;
        }

        bool mouse = Input.GetKey("mouse 0");
        if (mouse) {
            float mouseY = Input.GetAxis("Mouse Y");
            float diff = -mouseY * 5;
            fixedRotX += diff;
            
            if (fixedRotX < ceilRotateValue) fixedRotX = ceilRotateValue;
            else if (fixedRotX > floorRotateValue) fixedRotX = floorRotateValue;
        }
    }

    void LateUpdate ()
    {
        transform.rotation = Quaternion.Euler(
            fixedRotX,
            transform.rotation.eulerAngles.y,
            fixedRotZ
        );

        transform.position = new Vector3(
            transform.position.x,
            fixedPosY,
            transform.position.z
        );
    }
}