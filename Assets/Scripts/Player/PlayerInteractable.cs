using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerInteractable : MonoBehaviour
{
    protected abstract void Interact(Player player);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();
            if (player != null)
            {
                Interact(player);
                Destroy(gameObject);
            }
        }
    }
}
