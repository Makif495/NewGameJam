using UnityEngine;

public class GamePause : MonoBehaviour
{
    public GameObject pauseMenuUI; // Men� UI nesnesi burada tan�mlanacak
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
        pauseMenuUI.SetActive(true); // Men�y� g�r�n�r yapar
        Time.timeScale = 0f; // Oyun durur
        isPaused = true;
    }

    void ResumeGame()
    {
        pauseMenuUI.SetActive(false); // Men�y� gizler
        Time.timeScale = 1f; // Oyun devam eder
        isPaused = false;
    }
}
