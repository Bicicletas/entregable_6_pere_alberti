using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed = 5f;
    private float yRange = 6f;
    private float xRange = 16.5f;

    void Update()
    {

        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.x > xRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -xRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > yRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -yRange)
        {
            Destroy(gameObject);
        }
    }
}
