using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource musicSource;

    public GameObject gameOverUI;

    public void GameOver()
    {
        Debug.Log("Game Over triggered.");
        musicSource.Stop();
        gameOverUI.SetActive(true);
        Time.timeScale = 0f; // Pauses the game
    }

    public void RestartGame()
    {
        Debug.Log("RestartGame called");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

