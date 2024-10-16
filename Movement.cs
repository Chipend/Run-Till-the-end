using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public Button buttonKiri;
    public Button buttonKanan;

    void Start()
    {
        buttonKiri.onClick.AddListener(MoveLeft);
        buttonKanan.onClick.AddListener(MoveRight);
    }

    void MoveLeft()
    {
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }

    void MoveRight()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
}