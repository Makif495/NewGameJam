using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharContr : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    Vector2 movement;
    public Animator anmtr;
    bool facingRight = true;
    public AudioSource audioS;
    public AudioClip sword;
    public enemy enemy;

    private float fireRateLive;
    public float fireRate;
    private bool isAttacked;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anmtr = GetComponent<Animator>();
        audioS=GetComponent<AudioSource>();

    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        if (Input.GetButtonDown("Fire1")&&!isAttacked)
        {
            anmtr.SetTrigger("attack");
            audioS.PlayOneShot(sword);
            fireRateLive = 0;
        }

        if (fireRateLive < fireRate) 
        { 
        fireRateLive=fireRateLive + .3f * Time.deltaTime;
            isAttacked = true;
        }
        else
        {
            isAttacked = false;
        }

        if (enemy.isHiting == true)
        {
            getDamage();

        }



    }

    private void FixedUpdate()
    {

        


        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        if (movement.y != 0 || movement.x != 0)
        {
            anmtr.SetBool("isRunning", true);

        }
        else
        {
            anmtr.SetBool("isRunning", false);
        }

        if (movement.x < 0 && facingRight)
        {
            flip();
            facingRight = !facingRight;
        }
        else if (movement.x > 0 && !facingRight)
        {
            flip();
            facingRight = !facingRight;
        }
       
        



        void flip()
        {
            transform.Rotate(0, 180f, 0);
        }

        



 }
    void getDamage()
    {
        anmtr.SetTrigger("getDamage");
    }




}