using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject HealthBar;

    // Start is called before the first frame update
    // Update is called once per frame
    Vector3 position;

    private void Start()
    {
        position = this.transform.position;
        HealthBar = GameObject.Find("Bar");
        alive = true;
        Move();
    }

    void Update()
    {

    }

    public void Move()
    {
        while ()
        {
            StartCoroutine("EnemyMovement");
        }
    }

    IEnumerator EnemyMovement()
    {
        position = position - new Vector3(0, 1, 0);
        this.DamageCheck();
        yield return new WaitForSeconds(1); 
    }

    void DamageCheck()
    {
        if(position.y < -2)
        {
            HealthBar.GetComponent<HealthBar>().TakeDamage();
            Destroy(this);
        }

    }
}
