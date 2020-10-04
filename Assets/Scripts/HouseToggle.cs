using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseToggle : MonoBehaviour
{

    public GameObject hitKey;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hitKey.SetActive(true);
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        hitKey.SetActive(false);
    }
}
