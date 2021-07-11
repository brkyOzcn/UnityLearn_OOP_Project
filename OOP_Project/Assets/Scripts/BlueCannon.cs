using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCannon : Cannons
{    
    protected override void Start()
    {
        base.Start();
        ballPosition = new Vector3(3.388f, 1.391f, 19.782f);

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
            spawned.GetComponent<Renderer>().sharedMaterial.color = Color.blue;
        }
    }

    
}
