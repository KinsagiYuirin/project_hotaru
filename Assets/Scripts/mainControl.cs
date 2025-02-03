using UnityEngine;

public class mainControl : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // การควบคุมการเคลื่อนที่
        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector3(moveInput * moveSpeed, rb.linearVelocity.y, 0);
        
        // การกระโดด
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, rb.linearVelocity.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ตรวจจับการอยู่บนพื้น
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // ตรวจจับเมื่อออกจากพื้น
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}