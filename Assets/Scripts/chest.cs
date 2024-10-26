using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class chest : MonoBehaviour
{
    public Animator anmtr;
    public TextMeshProUGUI text1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {

            anmtr.SetBool("acikMi", true);
            text1.text = "sandýk açýldý";
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anmtr.SetBool("acikMi", false);
            text1.text = "";

        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
