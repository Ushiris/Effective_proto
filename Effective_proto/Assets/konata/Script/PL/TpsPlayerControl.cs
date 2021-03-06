﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// カメラとプレイヤーの向きを制御
/// </summary>
public class TpsPlayerControl : MonoBehaviour
{

    [SerializeField] GameObject cameraPivot;
    [SerializeField] GameObject pl;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X") * Manager.GetManager.mouseSensitivity;
        float Y_Rotation = Input.GetAxis("Mouse Y") * Manager.GetManager.mouseSensitivity;
        pl.transform.Rotate(0, X_Rotation, 0);
        cameraPivot.transform.Rotate(-Y_Rotation, 0, 0);

    }
}
