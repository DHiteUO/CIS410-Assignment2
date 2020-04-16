using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    public Transform enemy;
    public CanvasGroup enemyDetectionImages;

    bool m_EnemyInRange = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == enemy)
        {
            m_EnemyInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == enemy)
        {
            m_EnemyInRange = false;
        }
    }

    void Update()
    {
        if (m_EnemyInRange)
        {
            //Calculate dot product to find angle between enemy and Johnlemon
            //Display appropriate image for the angle the enemy is in relation to John
            //Use linear interp to find distance between enemy and John
            //Change intensity of light based on distance to enemy
        }
    }
}
