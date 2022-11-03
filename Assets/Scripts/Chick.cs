using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// INHERITANCE
public class Chick : Chicken
{
    static private int ChicksCounter = 0;
    private Vector3 defaultSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        // initialization of agent is required by parent class
        agent = GetComponent<NavMeshAgent>();
        defaultSpawnPoint = new Vector3(4, 4, 0);
        ChicksCounter++;
        AnimalName = "Chicks" + ChicksCounter;
        Debug.Log("Animal " + AnimalName + " has spawned!");
        base.Speed = 1.0f;
        base.Move();
    }

    // POLYMORPHISM
    public override void Spawn()
    {
        base.Spawn(defaultSpawnPoint);
    }
}
