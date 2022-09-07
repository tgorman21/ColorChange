using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private float t = 0f;
    public float spawnRate = 1;
    public GameObject enemy;
    public Transform [] spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > spawnRate)
        {


            GameObject instEnemy = Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Length)]);

            t = 0;

        }
    }
}

