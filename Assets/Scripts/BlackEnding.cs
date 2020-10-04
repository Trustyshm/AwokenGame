using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackEnding : MonoBehaviour
{

    public GameObject endingText;
    public GameObject mainMenu;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BlackEndingStart());
    }

    IEnumerator BlackEndingStart()
    {
        yield return new WaitForSeconds(1.5f);
        endingText.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(true);

    }

}
