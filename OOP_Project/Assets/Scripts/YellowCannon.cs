using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCannon : Cannons
{
    protected override void Start()
    {
        base.Start();
        ballPosition = new Vector3(-0.009f, 1.429f, 19.859f);
    }

    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        SetBallColor();
    }
    protected override void SetBallColor()
    {
        if (spawned != null)
        {
            spawned.GetComponent<Renderer>().sharedMaterial.color = Color.yellow;
        }
    }
}
