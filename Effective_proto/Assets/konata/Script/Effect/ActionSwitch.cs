using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// アーツを生成する制御ユニット
/// </summary>
public class ActionSwitch : MonoBehaviour
{
    [Header("火の玉の速さ")]
    public float speed = 10;
    [Header("爆破するタイミング")]
    public float explosionInterval = 0.1f;
    [Header("火の玉を待機させる時間")]
    public float shotInterval = 0.1f;
    [Header("存在できる時間")]
    [SerializeField] float lifeTime = 10f;

    [SerializeField] GameObject instantParticle;

    public static ActionSwitch GetActionSwitch;

    GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        GetActionSwitch = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (OnTrigger())
        {
            //パーティクルを生成
            obj = Instantiate(instantParticle, transform.position, transform.localRotation);
            Destroy(obj, lifeTime);

            //SE
            SE_Manager.SePlay(SE_Manager.SE_NAME.Magic);
        }
    }

    bool OnTrigger()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
