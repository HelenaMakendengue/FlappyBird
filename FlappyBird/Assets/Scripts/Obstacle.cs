using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    public float speed;

    private void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;

        if(transform.position.x < -15) {
            Destroy(gameObject);
        }
    }
}
