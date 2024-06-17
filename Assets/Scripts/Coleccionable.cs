using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    public Animator animator;

    private bool collected = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !collected)
        {
            if (animator != null)
            {
                animator.SetBool("Collected", true);
            }

            collected = true;

            Destroy(gameObject, 0.5f);
        }
    }
}


