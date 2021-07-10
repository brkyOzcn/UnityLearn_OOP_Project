using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cannons : MonoBehaviour
{
    [SerializeField] protected GameObject ballPrefab;
    protected Vector3 ballPosition;
    protected GameObject spawned;
    private int ballSpeed = 10;

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
    }

    protected void FireBall(Vector3 ballPosition)
    {
        if (spawned == null)
        {
            spawned = Instantiate(ballPrefab, ballPosition, ballPrefab.transform.rotation);
        }

        spawned.transform.Translate(ballSpeed * Time.deltaTime * Vector3.back);
        
    }

   

}
