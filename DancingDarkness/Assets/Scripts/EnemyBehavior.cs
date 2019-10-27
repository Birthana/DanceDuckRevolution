using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject HealthBar;
    public bool moving;

    // Start is called before the first frame update
    // Update is called once per frame
    private void Start()
    {
        HealthBar = GameObject.Find("Bar");
        moving = true;
        Move();
    }

    public void Move()
    {
        StartCoroutine("EnemyMovement");
    }

    IEnumerator EnemyMovement()
    {
        for (int i = 0; i < 6; i++)
        {
            if (moving)
            {
                this.GetComponent<Transform>().position -= new Vector3(0, 1, 0);
                if (this.GetComponent<Transform>().position.y < -2.0f)
                {
                    HealthBar.GetComponent<HealthBar>().TakeDamage();
                    this.GetComponent<Animator>().SetBool("IsDead", true);
                    this.GetComponent<BoxCollider2D>().enabled = false;
                    moving = false;
                    yield return new WaitForSeconds(0.3f);
                    Destroy(this.gameObject);
                }
                yield return new WaitForSeconds(1);
            }
        }
    }

    void DamageCheck()
    {
        
    }
}
