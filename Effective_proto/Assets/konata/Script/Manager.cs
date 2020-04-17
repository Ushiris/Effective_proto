using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [Header("マウス感度")]
    public float mouseSensitivity = 1f;

    public static Manager GetManager { private set; get; }

    // Start is called before the first frame update
    void Start()
    {
        GetManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
