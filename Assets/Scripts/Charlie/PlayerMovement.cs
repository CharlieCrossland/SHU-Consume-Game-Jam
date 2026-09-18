using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Movement")]
    [SerializeField] private float moveSpeed;

    float inputs;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MovementDetection();
        Movement();
    }

    private void MovementDetection()
    {
        inputs = Input.GetAxisRaw("Horizontal");
    }

    private void Movement()
    {
        rb.MovePosition(new(rb.position.x + inputs * moveSpeed, rb.position.y));
    }
}
