using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{
    public string sceneName;
    // Triggers Try Again text
    // Load the same scene once player clicks anywhere in the scene

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag == "Deadly")
        {
            OnExplode();
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }

    void OnExplode()
    {
        Destroy(gameObject);
    }
}
