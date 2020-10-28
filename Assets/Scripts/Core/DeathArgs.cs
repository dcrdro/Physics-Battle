﻿using UnityEngine;

public struct DeathArgs
{
    public GameObject Origin { get; } 
    public GameObject Dealer { get; }

    public DeathArgs(GameObject origin, GameObject dealer)
    {
        Origin = origin;
        Dealer = dealer;
    }
}