using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーンを切り替える
/// </summary>
public class SceneChange : MonoBehaviour
{

    [SerializeField] string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OnTrigger())
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    bool OnTrigger()
    {
        return Input.GetKeyDown(KeyCode.Escape);
    }
}
