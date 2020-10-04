using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorbell : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip doorbell;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            audioSource.PlayOneShot(doorbell);
            
        }
    }
}
