using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Sprite[] ducks = new Sprite[2];
    public AudioSource audioMove;

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
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position = new Vector2(-1.5f, -2.5f);
                sprite.sprite = ducks[1];
                audioMove.Play();
            }
            else if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position = new Vector2(0.5f, -2.5f);
                sprite.sprite = ducks[1];
                audioMove.Play();
            }
        }
        else if(transform.position.x == -1.5)
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position = new Vector2(-1.5f, -2.5f);
            }
            else if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position = new Vector2(-0.5f, -2.5f);
                sprite.sprite = ducks[0];
                audioMove.Play();
            }
        }
        else if(transform.position.x == 0.5)
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position = new Vector2(-0.5f, -2.5f);
                sprite.sprite = ducks[0];
                audioMove.Play();
            }
            else if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position = new Vector2(0.5f, -2.5f);
            }
        }
    }
}
