using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public GameObject projectile;
    public bool cooldown = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !cooldown)
        {
            Attack();
            cooldown = true;
        }
    }

    public void Attack()
    {
        StartCoroutine("Cooldown");
    }

    IEnumerator Cooldown()
    {
        Instantiate(projectile, this.GetComponent<Transform>().position, Quaternion.identity);
        yield return new WaitForSeconds(2);
        cooldown = false;
    }

}
