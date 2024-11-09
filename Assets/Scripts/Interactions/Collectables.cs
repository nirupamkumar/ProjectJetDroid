using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : PlayerInteractable
{
    public AudioClip pickupsound;

    protected override void Interact(Player player)
    {
        if (pickupsound != null)
        {
            AudioSource.PlayClipAtPoint(pickupsound, transform.position);
        }
    }
}
