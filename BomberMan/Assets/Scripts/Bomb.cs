using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    [SerializeField] private LayerMask explosionMask;
    [SerializeField] private float explosionDelay = 2f;
    [SerializeField] private float explosionRadius = 1f;

    private void Start()
    {
        Explode();
    }

    private void Explode()
    {
        var colliders = Physics2D.OverlapCircleAll(transform.position, explosionRadius, explosionMask);
        foreach (var cldr in colliders)
        {
            if (cldr.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            Destroy(cldr.gameObject, explosionDelay);
        }
        Destroy(this.gameObject, explosionDelay);
    }
}
