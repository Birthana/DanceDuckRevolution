using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    //spawn
    //fall
    //deal damage
    public GameObject[] EnemyType;

    float SpawnHeight = 3.5f;
    float[] position = new float[3];
    int counter = 0;
    
    private void Start()
    {
        Spawn();
    }

    private void Update()
    {
        if (counter == 100)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void Spawn()
    {
        StartCoroutine("Spawning");

    }

    IEnumerator Spawning() {
        while( counter < 100) {
            position[0] = Random.Range(1, 4) - 2.5f;
            position[1] = SpawnHeight;
            position[2] = 0;
            int EnemyVariant = Random.Range(0, 4);
            //check tags instead of class?
            GameObject tempEnemy = Instantiate(EnemyType[EnemyVariant], new Vector3(position[0], position[1], position[2]), Quaternion.identity);
            
            //returns game object. = a variable that is the game object. use that game object variable to change 
            //tempEnemy.GetComponent<SpriteRenderer>().sprite = images[EnemyVariant];
            counter++;
            yield return new WaitForSeconds(2);
        }
    }
}
