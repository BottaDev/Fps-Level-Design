using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Vector3 NewPosition;
    public List<GameObject> enemies;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 12 && CheckEnemies())
            other.transform.position = NewPosition;
    }

    private bool CheckEnemies()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i] != null)
                return false;
        }
        
        return true;
    }
}
