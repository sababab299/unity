using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    public Rigidbody rb;
    public float jumpForce;

    private bool canJump = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {   
        transform.Rotate(0, Input.GetAxisRaw("Horizontal") * rotateSpeed * Time.deltaTime, 0);
        transform.Translate(0, 0, Input.GetAxisRaw("Vertical")* speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(0, jumpForce, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
            jumpForce = 1000;
            speed = 30;
        }
        if (collision.gameObject.CompareTag("Ground1"))
        {
            canJump = true;
            jumpForce = 500;
            speed = 10;
        }

        Debug.Log(collision.gameObject.name);
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = false;
        }
        if (collision.gameObject.CompareTag("Ground1"))
        {
            canJump = false;
        }
        Debug.Log(collision.gameObject.name);
    }
}