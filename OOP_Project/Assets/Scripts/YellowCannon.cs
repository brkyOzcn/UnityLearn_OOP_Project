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
    private void Update()
    {
        FireBall(ballPosition);
    }


}
