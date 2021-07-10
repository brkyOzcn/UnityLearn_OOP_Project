using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCannon : Cannons
{
    
    protected override void Start()
    {
        base.Start();
        ballPosition = new Vector3(-3.142f, 1.379f, 19.859f);
    }

    private void Update()
    {
        FireBall(ballPosition);
    }


}
