using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// INHERITANCE
[RequireComponent(typeof(NavMeshAgent))]
public class Chicken : Animal
{
    static private int ChickenCounter = 0;
    private Rigidbody chickenRb;
    protected NavMeshAgent agent;

    // POLYMORPHISM
    public override void Move()
    {
        agent.SetDestination(RandomPosition());
        agent.speed = base.Speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        base.Speed = 2.0f;
        ChickenCounter++;
        AnimalName = "Chicken" + ChickenCounter;
        Debug.Log("Animal " + AnimalName + " has spawned!");
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (agent.destination - gameObject.transform.position).magnitude;
        if (distance < 0.5f)
        {
            Move();
        }
    }
}
