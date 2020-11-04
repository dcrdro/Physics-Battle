﻿using UnityEngine;

namespace Core.Interacting
{
    public interface ICollidable
    {
        // add event ?
    
        LayerMask CollidableLayer { get; }
        void OnCollide(Collision2D collision);
    }
}
