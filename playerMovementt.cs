using UnityEngine;

public class playerMovementt : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        float verticalMove = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(horizontalMove, verticalMove).normalized * speed * Time.deltaTime;

        transform.Translate(movement);
    }
}