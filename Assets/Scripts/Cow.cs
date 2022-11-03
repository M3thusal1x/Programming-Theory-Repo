using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// INHERITANCE
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(BoxCollider))]
public class Cow : Animal
{
    private static int CowCounter = 0;
    private NavMeshAgent agent;
    private BoxCollider boxCollider;
    private Vector3[] wayPoints = new Vector3[3];
    private int currentWayPointIndex = 0;
    private bool isMoving = false;

    // ABSTRACTION
    // POLYMORPHISM
    public override void Move()
    {
        agent.SetDestination(NextWayPoint());
        isMoving = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        wayPoints[0] = new Vector3(-20, 0, -2);
        wayPoints[1] = new Vector3(20, 0, 3);
        wayPoints[2] = new Vector3(0, 0, -5);
        CowCounter++;
        base.Name = "Cow" + CowCounter;
        base.Speed = 3.0f;
        agent = GetComponent<NavMeshAgent>();
        boxCollider = GetComponent<BoxCollider>();
        Debug.Log("Animal " + base.Name + " has spawned!");
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            float distance = (agent.destination - gameObject.transform.position).magnitude;
            if (distance < 0.5f)
            {
                Move();
            }
        }
    }

    private Vector3 NextWayPoint()
    {
        currentWayPointIndex++;
        // start from index 0, if index == 3
        currentWayPointIndex %= wayPoints.Length;
        return wayPoints[currentWayPointIndex];
    }
}
