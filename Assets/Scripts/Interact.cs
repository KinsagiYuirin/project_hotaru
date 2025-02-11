using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Serialization;

public class Interact : MonoBehaviour
{
    private bool canInteract = false;
    public bool CanInteract => canInteract;
    
    [Header("Interact Text")]
    [SerializeField] private TMP_Text interactText;

    protected void Start()
    {
        interactText.gameObject.SetActive(false);
    }

    protected void Update()
    {
        InteractObj();
    }
    
    private void InteractObj()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractAbilityObj();
        }
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = true;
            ShowText();
        }
    }
    
    protected void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = false;
            ShowText();
        }
    }
    private void ShowText()
    {
        if (canInteract)
        {
            TextObj();
            interactText.gameObject.SetActive(true);
        }
        else
        {
            interactText.gameObject.SetActive(false);
        }
    }
    
    // Method สำหรับการแสดงข้อความ
    protected virtual void TextObj()
    {
        interactText.text = "Press E to Interact";
    }
    
    // Method สำหรับการทำงานเมื่อ Interact
    protected virtual void InteractAbilityObj()
    {
        Debug.Log("Interacted");
    }
}       

