using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class DialogueManager : MonoBehaviour
{

    private Queue<string> sentences;

    public TMPro.TextMeshProUGUI dialogueText;

    public GameObject barKeep;


    public ChoiceMenu callChoices;
    

    public bool doOnce = false;

    public AudioSource audioSource;
    public AudioClip[] clips;

    public GameObject choice05;
    public GameObject exitButton;
    public GameObject fadeIn;

    private GameObject coinGame = null;


    void Start()
    {
        sentences = new Queue<string>();
        callChoices.choice01.gameObject.SetActive(false);
        callChoices.choice02.gameObject.SetActive(false);
        callChoices.choice03.gameObject.SetActive(false);
        callChoices.choice04.gameObject.SetActive(false);
        callChoices.exitButton.gameObject.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    public void ResetDialogue()
    {
        sentences = new Queue<string>();
        callChoices.choice01.gameObject.SetActive(false);
        callChoices.choice02.gameObject.SetActive(false);
        callChoices.choice03.gameObject.SetActive(false);
        callChoices.choice04.gameObject.SetActive(false);
        callChoices.exitButton.gameObject.SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
        callChoices.exitButton.gameObject.SetActive(true);
    }

    public void DisplayNextSentence()
    {

        if (sentences.Count == 0)
        {
            if (dialogueText.text.Contains("*"))
            {
                return;
            }
            EndDialogue();
            return;
        }

        

        string sentence = sentences.Dequeue();
        
        if (sentence.Contains("*"))
        {
            callChoices.DisplayChoices();
        }




        dialogueText.text = sentence;
        if (dialogueText.text.Contains(";"))
        {
            coinGame = GameObject.FindGameObjectWithTag("coinmenu");
            coinGame.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }

        ClipRandomizer();
        audioSource.PlayOneShot(audioSource.clip);
    }


    void EndDialogue()
    {
        
        if (dialogueText.text.Contains("!"))
        {
            dialogueText.text = "";
            choice05.gameObject.SetActive(false);
            exitButton.gameObject.SetActive(false);
            dialogueText.text = "I have just the thing...";
            StartCoroutine(LoadNextLevel());

        } else {
            if (dialogueText.text.Contains("I have just the thing..."))
            {
                return;
            }
            else
            {
                barKeep.GetComponent<DialogueTrigger>().TriggerDialogue();
            }
            
        }
        
    }

    IEnumerator LoadNextLevel()
    {

        yield return new WaitForSeconds(3f);
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(3f);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }

    void ClipRandomizer()
    {
        audioSource.clip = clips[Random.Range(0, clips.Length)];
    }
}
