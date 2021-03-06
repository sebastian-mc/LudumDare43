﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector : MapBlock {

    private Obstacle obstacle;

    public override void Init()
    {
        base.Init();
        obstacle = map.GetObstacle(code);
        obstacle.OnDestroy += ObstacleDestroy;
        obstacle.OnChangeState += ObstacleChange;
    }

    public override void Destroy(float threshold)
    {
        return;
    }

    public override bool Action(int player, bool isInteractible)
    {
        FindObjectOfType<AudioManager>().PlaySound(AudioManager.Sound.No);
        return false;
    }

    private void ObstacleDestroy()
    {
        base.Destroy(0);
    }

    private void ObstacleChange()
    {
        //TODO: Change appeareance to appear "ON"
    }
}
