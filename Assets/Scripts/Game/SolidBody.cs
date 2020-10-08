﻿using UnityEngine;

public class SolidBody : MonoBehaviour
{
    [SerializeField] private Animator animator;

    [SerializeField] private Rigidbody2D solidRigidbody;
    [SerializeField] private Collider2D checkCollider;
    
    public void Activate()
    {
        solidRigidbody.isKinematic = false;
        animator.enabled = true;
        checkCollider.enabled = true;
    }

    public void Deactivate()
    {
        solidRigidbody.isKinematic = true;
        checkCollider.enabled = false;
        animator.enabled = false;
    }
}