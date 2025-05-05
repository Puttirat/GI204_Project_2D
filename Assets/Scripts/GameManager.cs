using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int coinsCollected = 0;
    public int coinsToWin = 3;
    public Text coinText;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void CollectCoin()
    {
        coinsCollected++;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + coinsCollected + "/" + coinsToWin;
        }
    }

    public bool AllCoinsCollected()
    {
        return coinsCollected >= coinsToWin;
    }
}
