using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bulletSpawner : MonoBehaviour
{
    public GameObject prefab;
    public int maxBullets;
    public int bullets;
    public float nextSpawnTime;
    public float spawnInterval;

    public TMP_Text bulletCount;

    private void Start()
    {
        nextSpawnTime = Time.time;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bullets > 0)
        {
            Shoot();
        }

        if (Time.time > nextSpawnTime)
        {

            if (bullets < maxBullets)
            {
                bullets += 1;
            }

            nextSpawnTime += spawnInterval;
        }

        bulletCount.text = bullets.ToString();

    }

    void Shoot()
    {

        var pos = transform.position;
        pos.z = transform.position.z;
        pos.x = transform.position.x + 1;
        var rot = Quaternion.Euler(new Vector3(0, 90, -90));

        Instantiate(prefab, pos, rot);

        bullets -= 1;
    }
}