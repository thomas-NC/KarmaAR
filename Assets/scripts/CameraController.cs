﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;


    private Vector3 offset;

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}