using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToContinue : MonoBehaviour
{
    public string scene;
    private bool loadLock;

    void Update()
    {
        if (Input.GetMouseButtonDown (0) && !loadLock) LoadScene();
    }

    void LoadScene()
    {
        loadLock = true;
        SceneManager.LoadScene("Level1");
    }
}
