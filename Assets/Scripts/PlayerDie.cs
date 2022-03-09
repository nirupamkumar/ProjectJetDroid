using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag == "Deadly")
        {
            OnExplode();
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }
    }

    void OnExplode()
    {
        Destroy(gameObject);

    }

}
