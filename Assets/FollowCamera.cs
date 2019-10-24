using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player;
    
    private WhitePlayer white;
    private Vector3 startRotation;
    private float startY;

    void Start()
    {
        startRotation = transform.rotation.eulerAngles;
        startY = transform.position.y;

        white = player.GetComponent<WhitePlayer>();
    }

    void Update()
    {
        if (white.isDied()) transform.parent = null;
    }

    void LateUpdate ()
    {
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
    }
}