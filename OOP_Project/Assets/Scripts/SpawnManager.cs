using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    public bool gameOver = false;
    public Color[] col =  {Color.blue, Color.yellow, Color.red};
    private int randomColor;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.5f, 1.5f);
    }

    void SpawnEnemy()
    {
        if (gameOver == false)
        {
            Instantiate(enemyPrefab, new Vector3(0, 2, -3), enemyPrefab.transform.rotation);
            randomColor = Random.Range(0, 3);
            enemyPrefab.GetComponent<Renderer>().sharedMaterial.color = col[randomColor];
        }
    }

}
