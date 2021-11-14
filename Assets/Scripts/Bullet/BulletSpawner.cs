using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletResource;
    public Vector3 position;
    public Quaternion rotation;
    public float cooldown;
    float timer;

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            Destroy(Instantiate(bulletResource, position, rotation), 4);
            timer = cooldown;
        }
        timer -= Time.deltaTime;
    }
}