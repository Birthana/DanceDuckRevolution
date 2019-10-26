using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    //spawn
    //fall
    //deal damage
    float SpawnHeight = 3.5f;
    float[] position = new float[3];
    public GameObject enemy;

    private void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        //it's not random. it always spawn on the left most column
        position[0] = Random.Range(1,4) - 2.5f;
        position[1] = SpawnHeight;
        position[2] = 0;
        //check tags instead of class?
        Instantiate(enemy, new Vector3(position[0],position[1],position[2]), Quaternion.identity);
    }
}
