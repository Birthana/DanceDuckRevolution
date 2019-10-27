using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollider: MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(Death(collision));
    }

    IEnumerator Death(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy" || collision.collider.tag == "Health")
        {
            collision.gameObject.GetComponent<Animator>().SetBool("IsDead", true);
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            collision.gameObject.GetComponent<EnemyBehavior>().moving = false;
            this.GetComponent<SpriteRenderer>().enabled = false;
            if (collision.collider.tag != "Health")
            {
                yield return new WaitForSeconds(0.3f);
            }
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    } 
}
