using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cannons : MonoBehaviour
{
    [SerializeField] protected GameObject ballPrefab;
    protected Vector3 ballPosition;
    protected static GameObject spawned;
    private int ballSpeed = 10;
    private SpawnManager gameStatus;

    protected virtual void Start()
    {
        var renderer = GetComponent<Renderer>();
        MaterialPropertyBlock cannonColor = new MaterialPropertyBlock();
        
        if (gameObject.CompareTag("Cannon1")) // Blue cannon
        {
            cannonColor.SetColor("_Color", Color.blue);
        } 
        else if (gameObject.CompareTag("Cannon2")) // Yellow cannon
        {
            cannonColor.SetColor("_Color", Color.yellow);
        } 
        else  // Red cannon
        {
            cannonColor.SetColor("_Color", Color.red);
        }

        renderer.SetPropertyBlock(cannonColor);

        gameStatus = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    private void Update()
    {
        if (spawned != null)
        {
            spawned.transform.Translate(ballSpeed * Time.deltaTime * Vector3.back);

            if (spawned.transform.position.z < -16)
            {
                Destroy(spawned);
            }
        }


    }

    protected virtual void OnMouseDown()
    {
        if (spawned == null & gameStatus.gameOver == false)
        {
            FireBall(ballPosition);
        }

    }

    protected void FireBall(Vector3 ballPosition)
    {
        spawned = Instantiate(ballPrefab, ballPosition, ballPrefab.transform.rotation);
    }

    protected abstract void SetBallColor();
}
