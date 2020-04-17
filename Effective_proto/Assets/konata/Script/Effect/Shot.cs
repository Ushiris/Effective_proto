using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 火の玉を飛ばす
/// </summary>
public class Shot : MonoBehaviour
{
    [SerializeField] GameObject instantParticle;

    bool on;

    // Start is called before the first frame update
    void Start()
    {
        //〇〇秒後に移動させる
        Invoke("Move", ActionSwitch.GetActionSwitch.shotInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (on)
        {
            //移動
            Vector3 pos = transform.localPosition;
            pos.z += ActionSwitch.GetActionSwitch.speed * Time.deltaTime;
            transform.localPosition = pos;
        }
    }

    void Move()
    {
        on = true;

        //SE
        SE_Manager.SePlay(SE_Manager.SE_NAME.Fire);
    }

    //物に触れた時爆発パーティクル制御を生成する
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Instantiate(instantParticle, other.transform.position, new Quaternion());
            Destroy(gameObject);
            
        }
    }
}
