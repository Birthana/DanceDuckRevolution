using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollider: MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
