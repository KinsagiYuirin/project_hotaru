using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Warp : Interact
{
    public Transform targetObject;
    public Transform targetPlayer;
    private Interact CanInteract;
    
    void Update()
    {
        if (CanInteract && Input.GetKeyDown(KeyCode.E))
        {
            MoveToTarget();
        }
    }

    void MoveToTarget()
    {
        if (targetObject != null)
        {
            targetPlayer.position = targetObject.position;
        }
    }
}