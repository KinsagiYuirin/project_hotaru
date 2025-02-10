using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Warp : Interact
{
    public Transform targetObject;
    public Transform targetPlayer;
    
    void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E))
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