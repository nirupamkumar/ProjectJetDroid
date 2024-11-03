using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDieTwo : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Deadly")
        {
            OnExplode();
            SceneManager.LoadScene("Level3.1", LoadSceneMode.Single);
        }
    }

    void OnExplode()
    {
        Destroy(gameObject);
    }
}
