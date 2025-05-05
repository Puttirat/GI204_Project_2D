using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    
    [SerializeField] private string gameplaySceneName = "Gameplay";


    public void LoadGameplayScene()
    {
        SceneManager.LoadScene(gameplaySceneName);
    }

    
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#else
            Application.Quit();                              
#endif
    }
}
