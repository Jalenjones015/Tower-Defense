using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Transform turn;
    public Transform target;
    public Transform point;
    public GameObject bulletpre;
    public float bullforce = 0f;
    public float betweenshots = 1f;
    private float tim = 0f;
    public float range;
    public string enemytag = "Dirt Hand";
    public string enemytag2 = "Mud";


    void Start()
    {
        InvokeRepeating("updatetarget", 0f, 0.6f);
        InvokeRepeating("updatetarget2", 0f, 0.5f);
    }
    void Update()
    {
        if (Time.time >= tim)
        {
            shoot();
            tim = Time.time + betweenshots;
        }
        if (target == null)
            return;

        Vector3 dir = target.position - transform.position;
        Quaternion look = Quaternion.LookRotation(dir);
        Vector3 rotation = look.eulerAngles;
        turn.rotation = Quaternion.Euler(0f, rotation.y, 0f);


    }

    void updatetarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemytag);
        float shortdistance = Mathf.Infinity;
        GameObject narenemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distancetoenemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distancetoenemy < shortdistance)
            {
                shortdistance = distancetoenemy;
                narenemy = enemy;
            }
        }

        if (narenemy != null && shortdistance <= range)
        {
            target = narenemy.transform;
        }
        else
        {
            target = null;
        }
    }

    void updatetarget2()
    {
        GameObject[] enemies2 = GameObject.FindGameObjectsWithTag(enemytag2);
        float shortdistance = Mathf.Infinity;
        GameObject narenemy2 = null;
        foreach (GameObject enemy in enemies2)
        {
            float distancetoenemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distancetoenemy < shortdistance)
            {
                shortdistance = distancetoenemy;
                narenemy2 = enemy;
            }
        }

        if (narenemy2 != null && shortdistance <= range)
        {
            target = narenemy2.transform;
        }
        else
        {
            target = null;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, range);
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

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mud")
        {
            Destroy(gameObject);
        }
    }
}
