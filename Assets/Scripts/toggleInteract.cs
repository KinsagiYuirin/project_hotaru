using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class toggleInteract : MonoBehaviour
{
    private Renderer objectRenderer;
    private bool canInteract = false;
    private bool isRed = false;
    private Color originalColor;
    [SerializeField] TMP_Text interactText;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
        if (interactText != null)
        {
            interactText.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            if (isRed)
            {
                objectRenderer.material.color = originalColor;
            }
            else
            {
                objectRenderer.material.color = Color.red;
            }
            isRed = !isRed;
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

