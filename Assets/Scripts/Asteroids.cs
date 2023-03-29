using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public float speed;
    public int asteroids;
    public GameObject asteroidGameobject;
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            for (int i = 0; i < asteroids; i++)
            {
                GameObject newAsteroid = Instantiate(asteroidGameobject, transform.position, Quaternion.identity);
                newAsteroid.transform.localScale = transform.localScale / 2f;
            }

            Destroy(gameObject);
        }
    }
}