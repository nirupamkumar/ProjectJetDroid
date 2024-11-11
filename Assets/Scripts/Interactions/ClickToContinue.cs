using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToContinue : MonoBehaviour
{
    private bool loadLock;

    void Update()
    {
        if (Input.GetMouseButtonDown (0) && !loadLock)
        {
            loadLock = true;
            SceneTransitionDelay();
        }
    }

    private async void SceneTransitionDelay()
    {
        await Task.Delay(600);
        LoadScene();
    }

    void LoadScene()
    {
        SceneManager.LoadScene("1_StoryIntro");
    }
}
