using UnityEngine;

public class changColor : Interact
{
    private Renderer objectRenderer;
    private Color originalColor;
    private bool isRed = false;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }
    
    void Update()
    {
        
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            changeColor();
        }
    }
    
    private void changeColor()
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
