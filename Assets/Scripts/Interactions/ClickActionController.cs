using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickActionController : MonoBehaviour
{
    public GameObject story;
    public GameObject objectives;
    public LoadingBar loadingBar;
    public TextMeshProUGUI clickToNext;
    private int clickCount = 0;
    private bool isSceneLoading = false;

    private void Awake()
    {
        story.SetActive(true);
        objectives.SetActive(false);
        clickToNext.text = "Click to Next..";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isSceneLoading)
        {
            clickCount++;

            if (clickCount == 1)
            {
                story.SetActive(false);
                objectives.SetActive(true);
                clickToNext.text = string.Empty;
                clickToNext.text = "Click to Continue..";
            }
            else if (clickCount == 2)
            {
                if (loadingBar != null)
                {
                    loadingBar.StartLoading();
                }

                clickCount = 0;
                isSceneLoading = true;
            }
        }

        if (loadingBar != null && loadingBar.IsLoadingComplete)
        {
            SceneManager.LoadScene("2_MainLevel");
        }

        if (loadingBar != null)
        {
            loadingBar.UpdateLoading();
        }
    }

}
