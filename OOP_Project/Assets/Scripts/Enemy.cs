using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SpawnManager gameStatus;
    private int enemySpeed = 10;

    void Start()
    {
        gameStatus = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    void Update()
    {
        Move();    
    }

    void Move()
    {
        if (gameObject.transform.position.z > 20)
        {
            gameStatus.gameOver = true;
            Destroy(gameObject);
        }

        gameObject.transform.Translate(Vector3.forward * Time.deltaTime * enemySpeed);

    }

}
