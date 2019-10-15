using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePlayer : MonoBehaviour
{
    AudioSource falling;
    bool failed = false;

    // Start is called before the first frame update
    void Start()
    {
        falling = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!failed && transform.position.y < -5)
        {
            Debug.Log(transform.position.y);
            falling.Play(0);
            failed = true;
        }
    }
}
