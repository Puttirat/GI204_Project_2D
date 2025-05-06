using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float fireRate = 10f; // ยิงทุกกี่วินาที (ปรับได้)

    private float fireCooldown = 0f;

    void Update()
    {
        // นับถอยหลังจนกว่า fireCooldown จะเหลือ 0
        fireCooldown -= Time.deltaTime;

        if (fireCooldown <= 0f)
        {
            Shoot();
            fireCooldown = fireRate; // รีเซ็ต cooldown หลังยิง
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}