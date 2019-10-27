using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
        StartCoroutine("ProjectileMovement");
    }

    IEnumerator ProjectileMovement()
    {
        for (int i = 6; i >= 0; i--)
        {
            this.GetComponent<Transform>().position += new Vector3(0, 1, 0);
            yield return new WaitForSeconds(1);
        }
        Destroy(this.gameObject);
    }
}
