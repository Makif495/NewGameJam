using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class Skeleton : enemy
{
    public Transform target;
    public float gorusAlani;
    public float menzil;

    void Start()
    {

        target = GameObject.FindGameObjectWithTag("Player").transform;

    }
    void alanKontrol()
    {
        if ((Vector2.Distance(target.position, transform.position)) <= gorusAlani && (Vector2.Distance(target.position,transform.position)) <= menzil);
        {
            transform.position = Vector2.MoveTowards(transform.position,target.position,karakterinHizi*Time.deltaTime);
        }
    }

    
     private void FixedUpdate()
    {
        alanKontrol();
    }
}
