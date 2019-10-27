using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollider: MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Before if statement");
        if(collision.collider.tag == "Enemy")
        {
            Debug.Log("Inside if statement");
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        Debug.Log("After if statement");
    }
        
}
