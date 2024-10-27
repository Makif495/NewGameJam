using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;

public class Skeleton : enemy
{
    public Animator anim;
    public Transform target;
    public float gorusAlani;
    public float menzil;
    public enemy enemyy;
    private bool atakYapabilir = false;
    public CharContr mainP;
    public bool isDead;

    void Start()
    {

        target = GameObject.FindGameObjectWithTag("Player").transform;

    }
    void alanKontrol()
    {
         
            if ((Vector2.Distance(target.position, transform.position)) <= menzil && atakYapabilir)
            {
                anim.SetBool("dead", true);
                isDead = true;
            }
        

        if (!isDead)
        {
            if ((Vector2.Distance(target.position, transform.position)) <= gorusAlani && (Vector2.Distance(target.position, transform.position)) > menzil)
            {
                anim.SetBool("running", true);
                transform.position = Vector2.MoveTowards(transform.position, target.position, karakterinHizi * Time.deltaTime);
            }
            else
            {
                anim.SetBool("running", false);
            }
        }
    }
    private void FixedUpdate()
    {
        if (atakHizi > mevcutAtakHizi)
        {
            mevcutAtakHizi = mevcutAtakHizi + .5f;
            atakYapabilir = false;
            isHiting = false;
        }

        else
        {
            mevcutAtakHizi = atakHizi; 
            atakYapabilir=true; 
        }



    }


    private void Update()
    {

        alanKontrol();

        if ((Vector2.Distance(target.position, transform.position)) <= menzil && atakYapabilir)
        {

            attack();
        }
        if (mainP.isAttackingToEnemy == true)
        {
            Debug.Log("sadasd");
            anim.SetBool("dead",true);
            getDamage();
        }

    }

    void attack()
    {
        atakYapabilir = false;
        isHiting = true;
        anim.SetTrigger("attack");
        mevcutAtakHizi = 0;
    }

    void getDamage()
    {
        
        anim.SetTrigger("getDamage");

    }




}
