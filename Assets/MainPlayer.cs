using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float vValue = Input.GetAxis("Vertical");
        transform.Translate(0, 0, vValue / (float) 20);

        bool mouse0 = Input.GetKey("mouse 0");
        if (mouse0) {
            float mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(0, mouseX * 10, 0);
        }
    }
}
