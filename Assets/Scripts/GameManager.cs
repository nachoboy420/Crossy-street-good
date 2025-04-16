using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    
    public GameObject gameOverUI;
    
    public void GameOver()
    {
        Debug.Log("Game Over triggered.");
        gameOverUI.SetActive(true);
        Time.timeScale = 0f; // Pauses the game
    }

    public void RestartGame()
    { 
        Debug.Log("RestartGame called");
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    Debug.Log(" Restart button works!");
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

}
    } 

