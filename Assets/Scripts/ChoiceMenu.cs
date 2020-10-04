using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChoiceMenu : MonoBehaviour
{
    DialogueManager instance;
    Dialogue dialogue;
    public DialogueTrigger trigger;

    public Button choice01;
    public Button choice02;
    public Button choice03;
    public Button choice04;
    public Button choice05;
    public Button exitButton;

    public GameObject choice04text;



    public TMPro.TextMeshProUGUI text;

    public GameObject fadeOut;


    public LoopPlayer loopCounter;


    private DialogueManager dialogueManager;

    public GameObject player;
    public GameObject moveSpot;
    public GameObject bar;

    public GameObject dialogueBackground;

    public EnterBar barEntry;

    


    private void Start()
    {

    }

    public void DisplayChoices()
    {
        
            choice01.gameObject.SetActive(true);
            choice02.gameObject.SetActive(true);
            choice03.gameObject.SetActive(true);
        Scene scene = SceneManager.GetActiveScene();   
        if (scene.name == "SampleScene")
        {
            if (loopCounter.GetComponent<LoopPlayer>().loopCount > 0)
            {
                choice04.gameObject.SetActive(true);
                choice04text.SetActive(true);
            }
        }
            
        if (scene.name != "SampleScene" && scene.name != "Level5")
        {
            choice05.gameObject.SetActive(true);

        }


        
    }


    // =============================


    public void choice01Identifier()
    {
        choice01 = choice01.GetComponent<Button>();
        choice01.onClick.AddListener(TaskOnClick01);
    }

    public void TaskOnClick01()
    {
        //dialogueBackground.SetActive(false);
        ReloadScene();
    }


    public void ReloadScene()
    {
        loopCounter.GetComponent<LoopPlayer>().loopCount += 1;
        barEntry.ExitTheBar();
        player.transform.position = moveSpot.transform.position;
    }




    // ==============================






    public void choice02Identifier()
    {
        choice04 = choice04.GetComponent<Button>();
        choice04.onClick.AddListener(TaskOnClick02);
    }

    public void TaskOnClick02()
    {
        choice01.gameObject.SetActive(false);
        choice02.gameObject.SetActive(false);
        choice03.gameObject.SetActive(false);
        choice04.gameObject.SetActive(false);
        choice05.gameObject.SetActive(false);
        //exitButton.gameObject.SetActive(false);
    }


    // ==============================






    public void choice03Identifier()
    {
        choice04 = choice04.GetComponent<Button>();
        choice04.onClick.AddListener(TaskOnClick03);
    }

    public void TaskOnClick03()
    {
        choice01.gameObject.SetActive(false);
        choice02.gameObject.SetActive(false);
        choice03.gameObject.SetActive(false);
        choice04.gameObject.SetActive(false);
        choice05.gameObject.SetActive(false);
        //exitButton.gameObject.SetActive(false);
    }


    // ==============================





    public void choice04Identifier()
    {
        choice04 = choice04.GetComponent<Button>();
        choice04.onClick.AddListener(TaskOnClick04);
    }

    public void TaskOnClick04()
    {
        StartCoroutine(LoadNextLevel());
        text.text = "";
        choice04.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
        text.text = "I have just the thing...";
        Debug.Log("Stuck in a loop");
    }

    IEnumerator LoadNextLevel()
    {
        
        yield return new WaitForSeconds(3f);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Level2");
    }

    // ==============================




    public void choice05Identifier()
    {
        choice04 = choice05.GetComponent<Button>();
        choice04.onClick.AddListener(TaskOnClick05);
    }

    public void TaskOnClick05()
    {
        choice01.gameObject.SetActive(false);
        choice02.gameObject.SetActive(false);
        choice03.gameObject.SetActive(false);
        choice04.gameObject.SetActive(false);
        choice05.gameObject.SetActive(false);
        //exitButton.gameObject.SetActive(false);
    }


    // ==============================





}
