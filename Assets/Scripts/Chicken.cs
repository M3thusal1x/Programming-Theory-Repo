using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Rigidbody))]
public class Chicken : Animal
{
    private Rigidbody chickenRb;
    private Vector3 target = new Vector3(-40, 0, 0);
    protected NavMeshAgent agent;
    
    public override void Jump()
    {
        chickenRb.AddRelativeForce(Vector3.up, ForceMode.Impulse);
    }

    public override void Move()
    {
        //chickenRb.MovePosition(target);
        agent.SetDestination(target);
        agent.speed = base.Speed;
    }



    // Start is called before the first frame update
    void Start()
    {
        base.Speed = 2.0f;
        agent = GetComponent<NavMeshAgent>();
        chickenRb = GetComponent<Rigidbody>();
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        int randomNumber = Random.Range(0, 10000);
        if (randomNumber == 0)
        {
            Jump();
        }
    }

}
