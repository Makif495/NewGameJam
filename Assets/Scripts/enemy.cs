using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public int karakterinCani;
    public string karakterinlsmi;
    public int karakterinVurusGucu;
    public float karakterinHizi;
    [HideInInspector] public bool isHiting;
    public float atakHizi;
    [HideInInspector] public float mevcutAtakHizi;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) // Oyuncu ile �arp��ma oldu�unda
        {
            isHiting = true; // isHiting'i true yapar
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) // Oyuncudan ayr�ld���nda
        {
            isHiting = false; // isHiting'i false yapar
        }
    }
}

