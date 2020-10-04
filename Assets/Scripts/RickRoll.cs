using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RickRoll : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip doorbell;
    public GameObject doorbellMenu;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //audioSource.clip = doorbell;
            Debug.Log("Hit for doorbell");
            audioSource.Play();
           
            //DoThis();
            

        }
    }
    /*
    void DoThis()
    {
        StartCoroutine(DoorbellMenu());
        Debug.Log("Running Coroutine");
    }

    IEnumerator DoorbellMenu()
    {
        doorbellMenu.SetActive(false);
        yield return new WaitForSeconds(25f);
        Debug.Log("Seconds done");
        doorbellMenu.SetActive(true);
    }

    */
}
