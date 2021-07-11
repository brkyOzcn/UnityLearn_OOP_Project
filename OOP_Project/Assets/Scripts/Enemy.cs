using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SpawnManager gameStatus;
    private const int enemySpeed = 20;

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
        if (gameObject.transform.position.z > 19)
        {
            gameStatus.gameOver = true;
            Destroy(gameObject);
        }

        gameObject.transform.Translate(enemySpeed * Time.deltaTime * Vector3.forward);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Renderer>().sharedMaterial.color == gameObject.GetComponent<Renderer>().sharedMaterial.color)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

}
