using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPlayer : MonoBehaviour
{
    public GameObject player;

    public int loopCount;

    public GameObject fadeToggle;

    // Start is called before the first frame update
    void Start()
    {
        loopCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        fadeToggle.SetActive(true);
        player.transform.position = new Vector3(player.transform.position.x - 200, player.transform.position.y, player.transform.position.z);
        loopCount += 1;
    }
}
