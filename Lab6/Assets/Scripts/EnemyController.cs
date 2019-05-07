using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent enemy;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        if(enemy == null)
        {
            enemy = this.gameObject.GetComponent<NavMeshAgent>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(target.position); 
    }
}
