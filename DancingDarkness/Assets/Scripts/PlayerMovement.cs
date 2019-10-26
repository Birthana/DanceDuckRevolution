using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x == 0.5)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position = new Vector2(-0.5f, -1.5f);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position = new Vector2(1.5f, -1.5f);
            }
        }
        else if(transform.position.x == -0.5)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position = new Vector2(-0.5f, -1.5f);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position = new Vector2(0.5f, -1.5f);
            }
        }
        else if (transform.position.x == 1.5)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position = new Vector2(0.5f, -1.5f);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position = new Vector2(1.5f, -1.5f);
            }
        }
    }
}
