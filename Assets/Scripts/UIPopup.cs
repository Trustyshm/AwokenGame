using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPopup : MonoBehaviour
{

    

    public GameObject hitKey;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        hitKey.SetActive(true);  
        this.GetComponent<EnterBar>().EnterTheBar();


        

        


    }
         
 
    private void OnTriggerExit2D(Collider2D collision)
    {

        hitKey.SetActive(false);


    }
}
