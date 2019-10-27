using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject HealthBar;

    // Start is called before the first frame update
    // Update is called once per frame
    private void Start()
    {
        HealthBar = GameObject.Find("Bar");
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
            this.GetComponent<Transform>().position -= new Vector3(0, 1, 0);
            DamageCheck();
            yield return new WaitForSeconds(1);
        }
    }

    void DamageCheck()
    {
        if(this.GetComponent<Transform>().position.y < -2.0f)
        {
            HealthBar.GetComponent<HealthBar>().TakeDamage();
            Destroy(this.gameObject);

        }
    }
}
