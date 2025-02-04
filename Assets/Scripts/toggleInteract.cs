using UnityEngine;

public class toggleInteract : MonoBehaviour
{
    private Renderer objectRenderer;
    private bool canInteract = false;
    private bool isRed = false;
    private Color originalColor;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
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
