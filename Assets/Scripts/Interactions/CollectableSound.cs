using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSound : MonoBehaviour
{
    public AudioClip pickupsound;

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag == "Player")
        {
            if (pickupsound)
                AudioSource.PlayClipAtPoint(pickupsound, transform.position);
            Destroy(gameObject);
        }
    }
}
