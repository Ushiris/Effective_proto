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

    // Start is called before the first frame update
    void Start()
    {
        txt.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Nenmy")
        {
            if (!nameList.Contains(other.name))
            {
                //リストに追加
                nameList.Add(other.name);

                //テキスト表示
                txt.text = "";
                for (int i = 0; i < nameList.Count; i++)
                {
                    txt.text += nameList[i] + "\n";
                }

                if (nameList.Count == 2)
                {
                    txt.text += "↓\n" + nameList[0] + "\n+\n" + nameList[1];
                }
            }
        }
    }
}
