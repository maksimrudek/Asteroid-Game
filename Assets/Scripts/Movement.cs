using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Movement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public AudioSource audio;

    private void Start()
    {
        audio.Play();
    }

    private void Update()
    {  
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector2(0, speed);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -speed);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity -= new Vector2(speed, rb.velocity.y);
        }

    }
        private void OnCollisionEnter2D(Collision2D col)
        {
            SceneManager.LoadScene(0);
        }
}
