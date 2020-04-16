using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Effect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            EffectBox box = other.GetComponent<EffectBox>();
            if (box == null)
            {
                box = other.gameObject.AddComponent<EffectBox>();
            }

            box.AddEffect(gameObject.GetComponent<TextMeshPro>().text);

            Destroy(gameObject);
        }
    }
}
