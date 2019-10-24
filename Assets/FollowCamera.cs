using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player; // тут объект игрока
    private Vector3 offset;

    private Vector3 startRotation;
    private float startY;

    void Start () 
    {        
        // offset = transform.position - player.transform.position;
        // startRotation = transform.position.rotation;
        startRotation = transform.rotation.eulerAngles;
        startY = transform.position.y;
    }

    void LateUpdate ()
    {
        // Debug.Log(transform.rotation.eulerAngles);
        transform.rotation = Quaternion.Euler(
            startRotation.x,
            transform.rotation.eulerAngles.y,
            startRotation.z
        );

        transform.position = new Vector3(
            transform.position.x,
            startY,
            transform.position.z
        );

        // transform.rotation.Set()
        // transform.eulerAngles = new Vector3(
        //     startRotation.x - player.transform.eulerAngles.x,
        //     transform.eulerAngles.y,
        //     startRotation.z - player.transform.eulerAngles.z
        // );
        // transform.eulerAngles.x = startRotation.x - player.transform.eulerAngles.x;
        // transform.eulerAngles.z = startRotation.z - player.transform.eulerAngles.z;
        // transform.position.rotation.z = 0;
        // transform.position = player.transform.position + offset;
        // transform.Rotate(0, 0, 0, Space.World);
        // transform.rotation = Quaternion.Euler(player.transform.rotation.x, player.transform.rotation.y, player.transform.rotation.z);
        // transform.rotation = player.transform.rotation;
        // transform.RotateAround(player.transform.position, 
        //     Vector3.up, player.transform.rotation.y);
    }
}