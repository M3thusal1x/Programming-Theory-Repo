using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// INHERITANCE
public class Chick : Chicken
{
    private Vector3 defaultSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        // initialization of agent is required by parent class
        agent = GetComponent<NavMeshAgent>();
        defaultSpawnPoint = new Vector3(4, 4, 0);
        base.Speed = 1.0f;
        base.Move();
    }

    // POLYMORPHISM
    public override void Spawn()
    {
        base.Spawn(defaultSpawnPoint);
    }
}
