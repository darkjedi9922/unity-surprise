using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    //private Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        //transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float vValue = Input.GetAxis("Vertical");
        float hValue = Input.GetAxis("Horizontal");
   
        transform.Translate(0, 0, vValue / (float) 5);
        transform.Rotate(0, hValue * 2, 0);
    }
}
