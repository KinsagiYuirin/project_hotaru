using Unity.Mathematics.Geometry;
using UnityEngine;

public class MainControl : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintSpeed = 8f;
    public float jumpForce = 7f;
    private Rigidbody rb;
    private bool isGrounded;
    private bool m_FacingRight = true;
    [SerializeField] private float moveInput;
    
    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // การควบคุมการเคลื่อนที่
        moveInput = Input.GetAxis("Horizontal");
        float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : moveSpeed;
        rb.linearVelocity = new Vector3(moveInput * currentSpeed, rb.linearVelocity.y, 0);
        animator.SetFloat("Speed", Mathf.Abs(moveInput));
        animator.SetFloat("Run", Mathf.Abs(currentSpeed));
        
        
        // การกระโดด
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, rb.linearVelocity.z);
            animator.SetBool("IsJumping", true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ตรวจจับการอยู่บนพื้น
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("IsJumping", false);
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

    private void FixedUpdate()
    {
        if (moveInput > 0 && !m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (moveInput < 0 && m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
    }
    
    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    
}