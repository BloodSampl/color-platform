using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    [SerializeField] Transform reSpawnPosition;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.position = reSpawnPosition.position;
    }
}
