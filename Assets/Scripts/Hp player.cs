using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;
    public Slider healthSlider;

    private bool isDead = false;

    void Start()
    {
        currentHP = maxHP;
        UpdateHealthBar();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHP -= damage;
        if (currentHP < 0) currentHP = 0;

        UpdateHealthBar();

        if (currentHP <= 0)
        {
            Die();
        }
    }

    void UpdateHealthBar()
    {
        if (healthSlider != null)
        {
            healthSlider.value = currentHP;
        }
    }

    // ✅ เปลี่ยนจาก private → public
    public void Die()
    {
        if (isDead) return;

        isDead = true;
        Debug.Log("Player Died");

        // ปิด GameObject หรือโหลดฉากใหม่
        gameObject.SetActive(false);
        
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }
}