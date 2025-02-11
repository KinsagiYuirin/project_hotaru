using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Warp : Interact
{
    public Transform targetObject;
    public Transform targetPlayer;

    protected override void InteractAbilityObj()
    {
        WarpPlayer();
    }
    
    private void WarpPlayer()
    {
        if (targetObject != null)
        {
            targetPlayer.position = targetObject.position;
        }
    }
}