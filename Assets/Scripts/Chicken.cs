using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// INHERITANCE
[RequireComponent(typeof(NavMeshAgent))]
public class Chicken : Animal
{
    private Rigidbody chickenRb;
    private Vector3 target = new Vector3(-40, 0, 0);
    private float jumpPower = 100000;
    protected NavMeshAgent agent;

    // POLYMORPHISM
    public override void Move()
    {
        agent.SetDestination(target);
        agent.speed = base.Speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        base.Speed = 2.0f;
        Move();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
