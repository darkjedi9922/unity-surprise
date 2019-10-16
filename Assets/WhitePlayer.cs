using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePlayer : MonoBehaviour
{
    AudioSource falling;

    // Start is called before the first frame update
    void Start()
    {
        falling = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
    	if (collider.gameObject.name == "Lava") falling.Play();
    }
}
