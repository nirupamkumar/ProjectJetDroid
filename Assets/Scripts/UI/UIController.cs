using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    // Health bar
    // Jet fuel bar
    // Level Title
    // Resume
    // Quit
    // Try again (in case of player death)

    public GameObject jetpackFuel;
    public GameObject pauseMenu;
    public GameObject tryAgain;

    private void Update()
    {
        //ClickAnywhereToTryAgain();
    }

    private void ClickAnywhereToTryAgain()
    {
        SceneManager.LoadScene("2_MainLevel", LoadSceneMode.Single);
    }
}
