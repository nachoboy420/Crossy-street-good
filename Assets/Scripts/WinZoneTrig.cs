using UnityEngine;

public class WinZoneTrig : MonoBehaviour
{
    public GameObject winScreen; // Assign the Win UI panel in Inspector

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            winScreen.SetActive(true);
            Time.timeScale = 0f; // Optional: pause the game
        }
    }
}


