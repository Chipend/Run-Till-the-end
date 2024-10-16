using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    public float speed = 2f;         // Kecepatan gerak
    public float jumpForce = 10f;    // Kekuatan lompatan (disesuaikan untuk 2 cm)
    public float moveInterval = 2f;  // Interval gerakan (2 detik)
    public float moveDistance = 5f;   // Jarak gerakan ke kanan

    private Rigidbody2D rb;
    private Animator animator;
    private float moveTimer;
    private bool movingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        moveTimer = moveInterval;
    }

    void Update()
    {
        // Timer untuk gerakan
        moveTimer -= Time.deltaTime;
        if (moveTimer <= 0)
        {
            movingRight = !movingRight; // Ubah arah gerakan
            moveTimer = moveInterval;
            Jump(); // Lompat saat mengubah arah
        }

        // Gerakkan karakter
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        // Update animasi
        animator.SetBool("isWalking", true); // Selalu berjalan
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        animator.SetTrigger("Jump"); // Trigger animasi lompat
    }
}