using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadCreditScene()
    {
        SceneManager.LoadScene("EndCredit"); 
    }
}
