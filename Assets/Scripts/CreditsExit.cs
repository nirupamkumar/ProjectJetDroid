using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsExit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pressed primary button.");
    }

    // Update is called once per frame
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
