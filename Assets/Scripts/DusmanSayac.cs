using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Tüm düþmanlar "düþman" olarak etiketlenecek
/*düþman kodunun içerisine bazý kodlar atýlmasý gerekli 
 public class Enemy : MonoBehaviour
{
    private DusmanSayacý dusmanSayacý;

    void Start()
    {
        dusmanSayacý = FindObjectOfType<DusmanSayacý>(); // Sahnedeki Dusmansayacý script'ine eriþim saðlar
    }

    public void Die()
    {
        // Düþman öldüðünde sayaç güncellenir
        dusmanSayacý.OnEnemyDefeated();
        Destroy(gameObject); // Düþmaný yok eder
    }
}*/
public class DusmanSayac : MonoBehaviour
{
   public Text dusmanSayacYazý;
   public int dusmanSayisi = 0;
  GameObject[] dusman;
    void Start()
    {
        //DusmanGuncelle();
    }
    /*
    //Düþmaný güncelleyecek
    public void DusmanGuncelle() {
        dusmanSayisi = GameObject.FindGameObjectsWithTag("Dusman").Length;
        dusmanSayacText.text = "Dusman: " + dusmanSayisi.ToString();
    }
    //Düþman ölünce Caðýrýlacak fonksiyon
    public void DusmanOlunce() {
        dusmanSayisi--;
        dusmanSayacText.text = "Düþman Kaldý" + dusmanSayisi;
        //bütün düþmanlar yenilince
        if (dusmanSayisi<=0)
        {
            Debug.Log("Tebrikler! Bütün düþmanlaýr alt ettin.");
        }
    }

*/

    private void Update() {
        dusman = GameObject.FindGameObjectsWithTag("dusman");
        dusmanSayacYazý.text = "Kalan Düþman\r\n" + dusman.Length.ToString();
    }
}
