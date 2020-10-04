using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    public Sprite image1;
    public Sprite highlightimage;
    private bool doOnce;

    public GameObject hintText;

    private void Start()
    {
        doOnce = false;
    }

    private void Update()
    {
        gameObject.GetComponent<Image>().sprite = image1;
        if (Input.GetKey("space"))
        {
            gameObject.GetComponent<Image>().sprite = highlightimage;
            if (doOnce == false)
            {
                hintText.SetActive(false);
                doOnce = true;
            }
        }
    }

    void MouseHovered()
        {
            gameObject.GetComponent<Image>().sprite = highlightimage;
        }

        void MouseUnhovered()
        {
            gameObject.GetComponent<Image>().sprite = image1;
        }
    

}
