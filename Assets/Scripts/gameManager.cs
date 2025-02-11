using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] lights;
    [SerializeField] private GetFirefly _firefly;
    void Start()
    {
        CloseLight();
    }

    void Update()
    {
        if (_firefly.Firefly1)
        {
            OpenLight();
        }
    }
    
    private void OpenLight()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].gameObject.SetActive(true); // เปิดไฟทั้งหมด
        }
    }
    
    private void CloseLight()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].gameObject.SetActive(false); // เปิดไฟทั้งหมด
        }
    }
}