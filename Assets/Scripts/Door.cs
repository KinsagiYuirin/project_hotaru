using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform targetObject;
    public Transform targetPlayer;
    private bool canInteract = false;

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = false;
        }
    }
}