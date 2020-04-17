using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーの移動
/// </summary>
public class PL_Move : MonoBehaviour
{
    Rigidbody rb;
    Vector3 move;
    Vector3 posSave;

    [SerializeField] float speed = 3;

    // Start is called before the first frame upda
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーが回転した時、動きもそれに合わせるための式
        float angleDir = transform.eulerAngles.y * (Mathf.PI / 180.0f);
        Vector3 dirVertical = new Vector3(Mathf.Sin(angleDir), 0, Mathf.Cos(angleDir));
        Vector3 dirHorizontal = new Vector3(-Mathf.Cos(angleDir), 0, Mathf.Sin(angleDir));

        //入力したときにカメラの向きを基準とした動き
        if (Input.GetAxis("Horizontal") != 0) move = -dirHorizontal * Input.GetAxis("Horizontal") * speed;
        if (Input.GetAxis("Vertical") != 0) move = dirVertical * Input.GetAxis("Vertical") * speed;



        //移動
        rb.AddForce(speed * (move - rb.velocity));
    }
}