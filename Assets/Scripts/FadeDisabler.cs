using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeDisabler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeDisable());
    }


    IEnumerator FadeDisable()
    {
        yield return new WaitForSeconds(1.2f);
        this.gameObject.SetActive(false);
    }
}
