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
    private string[] attackKey = { "Q", "W", "E", "R", "A", "S", "D", "F" };
    public string presentAttack;


    // Start is called before the first frame update
    void Start()
    {
        presentAttack = attackKey[Random.Range(0, 8)];
        attackText.GetComponent<Text>().text = presentAttack;
        sprite = this.GetComponent<SpriteRenderer>();
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
        GameObject attack = Instantiate(projectile, this.GetComponent<Transform>().position, Quaternion.identity);
        attack.GetComponent<SpriteRenderer>().sprite = dance[0];
        yield return new WaitForSeconds(2);
        cooldown = false;
    }

}
