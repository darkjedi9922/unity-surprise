using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    private WhitePlayer white;

    // Start is called before the first frame update
    void Start()
    {
        white = GetComponent<WhitePlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (white.isDied()) return;

        float vValue = Input.GetAxis("Vertical");
        transform.Translate(0, 0, vValue / (float) 20);

        bool mouse0 = Input.GetKey("mouse 0");
        if (mouse0) {
            float mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(0, mouseX * 10, 0);
        }
    }
}
