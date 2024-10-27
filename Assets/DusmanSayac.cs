using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DusmanSayac : MonoBehaviour
{
    public Text DusmanSay�Text;  // D��man say�s�n� g�sterecek UI metni
    private int dusmanSay�s�;        // Mevcut d��man say�s�
    GameObject Dusman;
    void Start() {
        UpdateEnemyCount();
    }

    // D��man say�s�n� g�nceller
    public void UpdateEnemyCount() {
        dusmanSay�s� = GameObject.FindGameObjectsWithTag("Dusman").Length;
        DusmanSay�Text.text = "Enemies Left: " + dusmanSay�s�;
    }

    // D��man �ld���nde �a�r�lacak
    public void OnEnemyDefeated() {
        dusmanSay�s�--;
        DusmanSay�Text.text = "Enemies Left: " + dusmanSay�s�;

        if (dusmanSay�s� <= 0) {
            Debug.Log("T�m d��manlar yenildi! Sava� sona erdi.");
            // Sava� bitti�inde yap�lacak i�lemler burada eklenebilir
        }
    }
}

