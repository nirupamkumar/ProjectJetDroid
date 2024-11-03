using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsExit : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Pressed primary button.");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            ExitButton();
    }

    void ExitButton()
    {
        SceneManager.LoadScene("Intro");
    }
}
