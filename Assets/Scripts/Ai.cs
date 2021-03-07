using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai : MonoBehaviour
{
    public Transform Play;
    public GameObject Enemy;
    NavMeshAgent en;

    void Start()
    {
        en = GetComponent<NavMeshAgent>();
        
    }

    private void Update()
    {
        en.SetDestination(Play.position);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hands")
        {
            Destroy(Enemy);
        }
    }

}


