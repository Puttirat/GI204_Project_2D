using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 5f;
    public float minVelocity = 0.1f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 forward = transform.right;
        rb.linearVelocity = forward * speed;

        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        if (rb.linearVelocity.magnitude < minVelocity)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // เรียก TakeDamage หรือ Die จาก Player
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.Die(); // ฆ่าทันที
            }

            Destroy(gameObject); // ทำลายกระสุน
        }

        if (collision.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}