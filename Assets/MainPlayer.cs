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
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (white.isDied()) return;

        float vValue = Input.GetAxis("Vertical");
        transform.Translate(0, 0, vValue / (float) 20);

        float hValue = Input.GetAxis("Horizontal");
        transform.Rotate(0, hValue * 2, 0);
    }
}
