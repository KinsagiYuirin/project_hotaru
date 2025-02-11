using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject[] lights;
    private getFirefly Firefly1;
    void Start()
    {
        if (lights != null)
        {
            foreach (GameObject light in lights)
            {
                light.gameObject.SetActive(false); // ปิดไฟทุกตัวเมื่อเริ่มเกม
            }
        }
    }

    void Update()
    {
        if (Firefly1 == true)
        {
            foreach (GameObject light in lights)
            {
                light.gameObject.SetActive(true); // เปิดไฟทั้งหมด
                Debug.Log("Turn on light");
            }
        }
    }
}