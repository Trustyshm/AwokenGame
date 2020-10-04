﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        FollowMe();
    }

    void FollowMe()
    {
        transform.position = player.transform.position + offset;
    }
}