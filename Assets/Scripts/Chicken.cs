using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Chicken : Animal
{
    private Rigidbody chickenRb;
    private Vector3 target = new Vector3(-40, 0, 0);
    private float jumpPower = 100000;
    protected NavMeshAgent agent;

    public override void Move()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target);
        agent.speed = base.Speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        base.Speed = 2.0f;
        Move();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
