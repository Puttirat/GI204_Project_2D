using UnityEngine;
using UnityEngine.SceneManagement; // ถ้าอยากโหลดฉาก

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.instance.AllCoinsCollected())
            {
                Debug.Log("WIN! เข้าเส้นชัยแล้ว");
                // ตัวอย่าง: โหลดฉากใหม่
                 SceneManager.LoadScene("End Game");
            }
            else
            {
                Debug.Log("ต้องเก็บเหรียญให้ครบก่อน!");
            }
        }
    }
}
