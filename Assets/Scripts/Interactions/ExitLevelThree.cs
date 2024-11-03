using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevelThree : MonoBehaviour
{
    public string sceneTwo;
  
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            Destroy(target.gameObject);
            SceneManager.LoadScene(sceneTwo);
        }
    }

}
