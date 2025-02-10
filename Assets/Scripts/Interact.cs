using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interact : MonoBehaviour
{
    
    public bool canInteract = false;
    [SerializeField] TMP_Text interactText;

    void Start()
    {
        
        if (interactText != null)
        {
            interactText.gameObject.SetActive(false);
            Debug.Log("interactText is not null");
        }
    }

    void Update()
    {
        
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            //interact();
        }
    }

    public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                canInteract = true;
                showText();
            }
        }
    
    public void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                canInteract = false;
                showText();
            }
        }
    public virtual void showText()
    {
        if (canInteract == true)
        {
            interactText.text = "Press E to Interact";
            interactText.gameObject.SetActive(true);
        }
        else
        {
            interactText.gameObject.SetActive(false);
            
        }
    }
}       

