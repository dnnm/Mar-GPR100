using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomCollectible : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other) 
    {
        RepositionCollectible();
    }
    
    void RepositionCollectible()
    {
        float newX = Random.Range(-5, 5);
        float newY = Random.Range(-3, 3);
        Vector2 newPos = new Vector2(newX, newY);
        transform.position = newPos;
    }
}
