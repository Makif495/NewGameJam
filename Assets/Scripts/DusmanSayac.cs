using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//T�m d��manlar "d��man" olarak etiketlenecek
/*d��man kodunun i�erisine baz� kodlar at�lmas� gerekli 
 public class Enemy : MonoBehaviour
{
    private DusmanSayac� dusmanSayac�;

    void Start()
    {
        dusmanSayac� = FindObjectOfType<DusmanSayac�>(); // Sahnedeki Dusmansayac� script'ine eri�im sa�lar
    }

    public void Die()
    {
        // D��man �ld���nde saya� g�ncellenir
        dusmanSayac�.OnEnemyDefeated();
        Destroy(gameObject); // D��man� yok eder
    }
}*/
public class DusmanSayac : MonoBehaviour
{
   public Text dusmanSayacYaz�;
   public int dusmanSayisi = 0;
  GameObject[] dusman;
    void Start()
    {
        //DusmanGuncelle();
    }
    /*
    //D��man� g�ncelleyecek
    public void DusmanGuncelle() {
        dusmanSayisi = GameObject.FindGameObjectsWithTag("Dusman").Length;
        dusmanSayacText.text = "Dusman: " + dusmanSayisi.ToString();
    }
    //D��man �l�nce Ca��r�lacak fonksiyon
    public void DusmanOlunce() {
        dusmanSayisi--;
        dusmanSayacText.text = "D��man Kald�" + dusmanSayisi;
        //b�t�n d��manlar yenilince
        if (dusmanSayisi<=0)
        {
            Debug.Log("Tebrikler! B�t�n d��manla�r alt ettin.");
        }
    }

*/

    private void Update() {
        dusman = GameObject.FindGameObjectsWithTag("dusman");
        dusmanSayacYaz�.text = "Kalan D��man\r\n" + dusman.Length.ToString();
    }
}
