using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPackBattery : PlayerInteractable
{
    protected override void Interact(Player player)
    {
        player.canUseJetpack = true;
    }
}
