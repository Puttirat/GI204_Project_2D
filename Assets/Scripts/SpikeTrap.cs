using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
            Debug.Log("Player hit spikes! Instant death!");

            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.Die(); // เรียกตายจากระบบ HP
            }
            else
            {
                // ถ้าไม่มีระบบ HP ก็ทำลาย GameObject
                Destroy(collision.gameObject);
            }
        }
    }
}