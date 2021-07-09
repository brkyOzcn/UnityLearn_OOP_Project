using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    public bool gameOver = false;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2, 5.0f);
    }

    
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        if (gameOver == false)
        {
            Instantiate(enemyPrefab.gameObject, new Vector3(0, 2, -3), enemyPrefab.gameObject.transform.rotation);
        }
    }

}
