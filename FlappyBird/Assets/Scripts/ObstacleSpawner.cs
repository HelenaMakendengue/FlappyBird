using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnTimerLength = 3;
    private float spawnTimer = 0;

    private void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer < 0)
        {
            spawnTimer = spawnTimerLength;

            //spawn a new obstacle
            Vector3 position = transform.position;
            position.y += (Random.value * 4) - 2;


            Quaternion rotation = Quaternion.identity;
            Instantiate(obstacle, position, rotation);
        }
    }
}
