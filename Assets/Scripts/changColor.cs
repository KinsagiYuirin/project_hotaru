using UnityEngine;

public class ChangColor : Interact
{
    private Renderer objectRenderer;
    private Color originalColor;
    private bool isRed = false;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }
    
    protected override void InteractAbilityObj()
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
