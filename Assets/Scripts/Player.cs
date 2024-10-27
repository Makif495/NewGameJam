using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] public int maxHealt = 100;
    [SerializeField] public int currentHealth = 100;
    public HealtBar healtBar;

    void Start() {
        currentHealth = maxHealt;
        healtBar.SetMaxHealth(maxHealt);
        healtBar.SetHealth(currentHealth);

    }

    void Update() {
        Debug.Log(currentHealth);
        if (Input.GetKeyDown(KeyCode.Space)) {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damage) {
        currentHealth -= damage;

        healtBar.SetHealth(currentHealth);

    }
    #region //DusmanAtak
    public class EnemyAttack : MonoBehaviour {
        public int hasar = 10;

        /* public void TakeDamage(int damage)
         {
             hasar = damage;
         }*/


        public void DestroyEnemy() {
            Destroy(gameObject);
        }
        public void OnCollisionEnter(Collision collision) {

            if (collision.gameObject.tag == "Player") {
                collision.gameObject.GetComponent<Player>().TakeDamage(hasar);
            }
            
            }

        }
        #endregion
    }


