using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 爆発するエフェクトの制御
/// </summary>
public class Explosion : MonoBehaviour
{
    [Header("その場で展開するパーティクルを選択")]
    [SerializeField] GameObject[] particleArr;
    bool on;

    // Start is called before the first frame update
    void Start()
    {
        float deleteTime = ActionSwitch.GetActionSwitch.explosionInterval;
        Invoke("InstantObj", deleteTime);
        Destroy(gameObject, deleteTime + 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 〇〇秒後にパーティクルを生成
    /// </summary>
    void InstantObj()
    {
        if (!on)
        {
            for (int i = 0; i < particleArr.Length; i++)
            {
                Instantiate(particleArr[i], transform);
            }
            on = true;
        }
    }
}
