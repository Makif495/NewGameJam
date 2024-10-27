using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StoryBalloon : MonoBehaviour
{
    public GameObject storyPanel; // Hikaye panelini buraya atayýn.
    public float displayTime = 15f;

    private void Start()
    {
        StartCoroutine(DisplayStoryBalloon());
    }

    private IEnumerator DisplayStoryBalloon()
    {
        // Hikaye baloncuðunu göster ve oyunu durdur
        storyPanel.SetActive(true);
        Time.timeScale = 0f;

        // 15 saniye bekleyin (gerçek zaman kullanýyoruz çünkü oyun durdu)
        yield return new WaitForSecondsRealtime(displayTime);

        // Hikaye baloncuðunu kapat ve oyunu devam ettir
        storyPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}

