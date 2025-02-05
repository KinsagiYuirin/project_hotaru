using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class interactWarp : MonoBehaviour
{
    public Transform targetObject;
    public Transform targetPlayer;
    private bool canInteract = false;
    [SerializeField] TMP_Text interactText;

    void Start()
    {
        if (interactText != null)
        {
            interactText.gameObject.SetActive(false);
        }
    }
    
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
            if (interactText != null)
            {
                interactText.text = "Press E to Interact";
                interactText.gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = false;
            if (interactText != null)
            {
                interactText.gameObject.SetActive(false);
            }
        }
    }
}