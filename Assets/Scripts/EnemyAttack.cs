using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
   public int hasar = 10;

   public void TakeDamage(int damage)
   {
       hasar = damage;
   }

   public void DestroyEnemy()
   {
       Destroy(gameObject);
   }
    public void OnCollisionEnter(Collision collision) {
        
    if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().TakeDamage(hasar);
        }
    }
    
}
