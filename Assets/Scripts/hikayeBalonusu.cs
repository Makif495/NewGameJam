using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StoryBalloon : MonoBehaviour
{
    public GameObject storyPanel; // Hikaye panelini buraya atay�n.
    public float displayTime = 15f;

    private void Start()
    {
        StartCoroutine(DisplayStoryBalloon());
    }

    private IEnumerator DisplayStoryBalloon()
    {
        // Hikaye baloncu�unu g�ster ve oyunu durdur
        storyPanel.SetActive(true);
        Time.timeScale = 0f;

        // 15 saniye bekleyin (ger�ek zaman kullan�yoruz ��nk� oyun durdu)
        yield return new WaitForSecondsRealtime(displayTime);

        // Hikaye baloncu�unu kapat ve oyunu devam ettir
        storyPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}

