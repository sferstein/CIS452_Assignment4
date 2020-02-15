using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private GameObject player;
    public GameObject enemyBullet;
    public GameObject firePoint;
    private Transform bulletSpawned;
    private Rigidbody enemyRb;
    private float currentTime;
    public float waitTime;
    private bool shot;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);

        this.transform.LookAt(player.transform);

        delay += Time.deltaTime;

        if (currentTime == 0)
        {
            Shoot();
        }

        if(shot && currentTime < waitTime)
        {
            currentTime += 1 * Time.deltaTime;
        }

        if(currentTime >= waitTime)
        {
            currentTime = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }

    public void Shoot()
    {
        shot = true;

        bulletSpawned = Instantiate(enemyBullet.transform, firePoint.transform.position, firePoint.transform.rotation);
        bulletSpawned.rotation = this.transform.rotation;
    }
}
