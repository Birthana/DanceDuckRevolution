using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{

    public SpriteRenderer sprite;
    public Sprite[] dance = new Sprite[8];

    public GameObject projectile;
    public bool cooldown = false;

    public GameObject attackText;
    string[] text = { "Q", "W", "E", "R", "A", "S", "D", "F" };
    KeyCode[] keyCodes = { KeyCode.Q, KeyCode.W, KeyCode.E, KeyCode.R,
                                   KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.F };
    int index;
    KeyCode attackKey;

    public AudioSource audioAttack;


    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range(0, 8);
        attackText.GetComponent<Text>().text = text[index];
        attackKey = keyCodes[index];
        sprite = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(attackKey) && !cooldown)
        {
            Attack();
            index = Random.Range(0, 8);
            attackText.GetComponent<Text>().text = text[index];
            attackKey = keyCodes[index];
            cooldown = true;
        }
    }

    public void Attack()
    {
        StartCoroutine("Cooldown");
    }

    IEnumerator Cooldown()
    {
        GameObject attack = Instantiate(projectile, this.GetComponent<Transform>().position, Quaternion.identity);
        sprite.sprite = dance[index];
        attack.GetComponent<SpriteRenderer>().sprite = dance[index];
        audioAttack.Play();
        yield return new WaitForSeconds(2);
        cooldown = false;
    }

}
