using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnterBar : MonoBehaviour
{

    public GameObject barCanvas;
    private bool enterBar;
    public GameObject playerBike;


    public GameObject barkeep;

    AudioSource audioSource;
    public AudioClip doorbell;

    public GameObject fadeOut;
    public GameObject fadeIn;
    public TMPro.TextMeshProUGUI dialogueText;

    public GameObject dialogueBackground;

    private bool doOnce;

    public GameObject dManager;

    public GameObject spaceMenu;

    private GameObject barMenu;


    private void Start()
    {
        enterBar = false;
        audioSource = GetComponent<AudioSource>();
        doOnce = false;
        barMenu = GameObject.FindGameObjectWithTag("BarMenu");
    }

    private void Update()
    {
        if (enterBar)
        {
            barMenu = GameObject.FindGameObjectWithTag("BarMenu");
            if (Input.GetKey(KeyCode.E) && doOnce == false && barMenu != null )
            {
                
                fadeOut.SetActive(true);
                spaceMenu.SetActive(false);
                barCanvas.SetActive(true);
                playerBike.SetActive(false);
                audioSource.PlayOneShot(doorbell);
                doOnce = true;
            }
        }

    }

    public void EnterTheBar()
    {
        enterBar = true;

    }

    public void ExitTheBar()
    {
        enterBar = false;
        playerBike.SetActive(true);
        dManager.GetComponent<DialogueManager>().ResetDialogue();
        fadeOut.SetActive(true);
        spaceMenu.SetActive(true);
        dialogueText.text = "";
        dialogueBackground.SetActive(false);
        barCanvas.SetActive(false);
        doOnce = false;

        

    }
}
