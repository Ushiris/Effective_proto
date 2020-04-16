using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    Vector3 axle = Vector3.up;  //回転の軸
    [SerializeField]
    float speed = 90;           //一秒で傾く角度。

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(axle, speed * Time.deltaTime);
    }
}
