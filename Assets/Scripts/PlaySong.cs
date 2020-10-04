using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySong : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip finalSong;
    public GameObject blackEnding;
    public GameObject bGM;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlayFinalSong()
    {
        bGM.gameObject.SetActive(false);
        audioSource.PlayOneShot(finalSong);
        blackEnding.SetActive(true);
    }

   
}
