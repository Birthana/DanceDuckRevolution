using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    //spawn
    //fall
    //deal damage
    public Sprite[] images;

    float SpawnHeight = 3.5f;
    float[] position = new float[3];
    public GameObject enemy;
    int counter = 0;
    
    private void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        StartCoroutine("Spawning");

    }

    IEnumerator Spawning() {
        while(counter < 10) {
            position[0] = Random.Range(1, 4) - 2.5f;
            position[1] = SpawnHeight;
            position[2] = 0;
            //check tags instead of class?
            GameObject tempEnemy = Instantiate(enemy, new Vector3(position[0], position[1], position[2]), Quaternion.identity);
            int EnemyVariant = Random.Range(0, 4);
            //returns game object. = a variable that is the game object. use that game object variable to change 
            tempEnemy.GetComponent<SpriteRenderer>().sprite = images[EnemyVariant];
            counter++;
            yield return new WaitForSeconds(2);
        }
    }
}
