using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Effect(アイテム)に触れた時触れたアイテムの名前をテキストで表示する
/// </summary>
public class EffectListDisplay : MonoBehaviour
{
    [SerializeField] Text txt;

    List<string> nameList = new List<string>();
    int tmpBok;

    // Start is called before the first frame update
    void Start()
    {
        txt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (tmpBok != EffectBox.box.Count)
        {
            tmpBok = EffectBox.box.Count;
            for (int i = 0; i < EffectBox.box.Count; i++)
            {
                txt.text += EffectBox.box[i] + "\n";
            }
        }
    }

  
}
