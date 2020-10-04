using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseIcon : MonoBehaviour
{
    public GameObject barScene;
    public RectTransform canvasRect;
    public GameObject chatBubbles;
    public Vector3 offset;
    
   

   
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (barScene.activeSelf == enabled){
           
           //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); mousePos.z = 0; speed = 150;
            
            chatBubbles.transform.position = offset + new Vector3(Input.mousePosition.x - canvasRect.sizeDelta.x / 2f, Input.mousePosition.y - canvasRect.sizeDelta.y / 2f);
        }
    }
}
