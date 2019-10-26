using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Sprite[] ducks = new Sprite[2];

    // Start is called before the first frame update
    void Start()
    {
        sprite = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x == -0.5)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position = new Vector2(-1.5f, -2.5f);
                sprite.sprite = ducks[1];
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position = new Vector2(0.5f, -2.5f);
                sprite.sprite = ducks[1];
            }
        }
        else if(transform.position.x == -1.5)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position = new Vector2(-1.5f, -2.5f);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position = new Vector2(-0.5f, -2.5f);
                sprite.sprite = ducks[0];
            }
        }
        else if (transform.position.x == 0.5)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position = new Vector2(-0.5f, -2.5f);
                sprite.sprite = ducks[0];
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position = new Vector2(0.5f, -2.5f);
            }
        }
    }
}
