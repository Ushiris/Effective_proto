using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Effect : MonoBehaviour
{
    [SerializeField]
    string effect_name = "undifined";
    [SerializeField]
    GameObject effect_bace;
    [SerializeField]
    bool StartSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        if(StartSpawn)
        {
            Spawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Spawn()
    {
        GameObject instance = Instantiate<GameObject>(effect_bace);
        instance.GetComponent<TextMeshPro>().text = effect_name;
        return instance;
    }
}
