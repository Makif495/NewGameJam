using UnityEngine;

public class GamePause : MonoBehaviour
{
    public GameObject pauseMenuUI; // Menü UI nesnesi burada tanýmlanacak
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        pauseMenuUI.SetActive(true); // Menüyü görünür yapar
        Time.timeScale = 0f; // Oyun durur
        isPaused = true;
    }

    void ResumeGame()
    {
        pauseMenuUI.SetActive(false); // Menüyü gizler
        Time.timeScale = 1f; // Oyun devam eder
        isPaused = false;
    }
}
