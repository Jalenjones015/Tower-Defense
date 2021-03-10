using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Transform point;
    public GameObject bulletpre;
    public float bullforce = 0f;
    public float betweenshots = 1f;
    private float tim = 0f;

    void Update()
    {
        if (Time.time >= tim)
        {
            shoot();
            tim = Time.time + betweenshots;
        }
    }

    public void shoot()
    {
        GameObject bullet = Instantiate(bulletpre, point.position, point.rotation);
        Destroy(bullet, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Debug.Log("Death by Bullet");
        }
    }
}
