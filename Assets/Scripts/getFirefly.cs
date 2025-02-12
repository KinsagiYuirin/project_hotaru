using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class GetFirefly : Interact
{
    
    [Header("Firefly")]
    [SerializeField] private GameObject fireflyObj;
    private bool firefly1;
    public bool Firefly1 => firefly1;
    
    protected override void InteractAbilityObj()
    {
        CollectFirefly();
    }

    void CollectFirefly()
    {
        fireflyObj.gameObject.SetActive(false); // ซ่อน Firefly
        firefly1 = true;
        Debug.Log("Collected a firefly!");
    }
    
    protected override void TextObj()
    {
        interactText.text = "Press E to collect firefly";
    }
}