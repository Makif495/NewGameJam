using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {
    public void PlayGame() {
        SceneManager.LoadScene(1);
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void Back() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

}
