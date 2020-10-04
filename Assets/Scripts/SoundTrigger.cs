using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip startSound;
    private bool doOnce;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        doOnce = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (doOnce == false)
        {
            audioSource.PlayOneShot(startSound);
            doOnce = true;
        }
        

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        doOnce = false;
    }
}
