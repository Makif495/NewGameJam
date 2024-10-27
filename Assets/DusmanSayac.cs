using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DusmanSayac : MonoBehaviour
{
    public Text DusmanSayýText;  // Düþman sayýsýný gösterecek UI metni
    private int dusmanSayýsý;        // Mevcut düþman sayýsý
    GameObject Dusman;
    void Start() {
        UpdateEnemyCount();
    }

    // Düþman sayýsýný günceller
    public void UpdateEnemyCount() {
        dusmanSayýsý = GameObject.FindGameObjectsWithTag("Dusman").Length;
        DusmanSayýText.text = "Enemies Left: " + dusmanSayýsý;
    }

    // Düþman öldüðünde çaðrýlacak
    public void OnEnemyDefeated() {
        dusmanSayýsý--;
        DusmanSayýText.text = "Enemies Left: " + dusmanSayýsý;

        if (dusmanSayýsý <= 0) {
            Debug.Log("Tüm düþmanlar yenildi! Savaþ sona erdi.");
            // Savaþ bittiðinde yapýlacak iþlemler burada eklenebilir
        }
    }
}

