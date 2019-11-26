using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePlayer : MonoBehaviour
{
    private AudioSource audioComponent;
    
    public AudioClip fallingSound;
    public AudioClip bounceSound;

    private bool died = false;

    // Start is called before the first frame update
    void Start()
    {
        audioComponent = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "chessman" || 
            collision.gameObject.name == "board")
        {
    	    audioComponent.PlayOneShot(bounceSound);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
    	if (collider.gameObject.name == "Lava") {
    		audioComponent.PlayOneShot(fallingSound);
            died = true;
    	}
    }

    public bool isDied()
    {
        return died;
    }
}
