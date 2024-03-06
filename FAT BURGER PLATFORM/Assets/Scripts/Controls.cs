public float movementSpeed = 3f;
    public float jumpSpeed = 500f;
    private bool isGrounded = true;
    private Rigidbody2D rb;
 
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
 
    void Update()
    {
        if (isGrounded)
        {using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public float movementSpeed = 3f; // Speed at which the sprite moves

    void Update()
    {
        // Move sprite left if A key or left arrow key is pressed
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        }

        // Move sprite right if D key or right arrow key is pressed
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
    }
}

            rb.gravityScale = 2.1f;
        }
 
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;

        }
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            if (!isGrounded)
            {
                rb.gravityScale += 2;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                rb.AddForce(Vector3.up * jumpSpeed);
                isGrounded = false;
            }
        }
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }