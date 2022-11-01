using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Abstract parent class for all animals.
public abstract class Animal : MonoBehaviour
{
    private float timeSinceSpawn = 0.0f;

    // internal Name
    private string m_Name = "Animal";
    // Animal name. Name length may not exceed 10 characters.
    public string Name
    {
        get { return m_Name; }
        set { 
            if (Name.Length > 10)
            {
                Debug.Log("You can't use animal names with more than 10 characters!");
            }
            else
            {
                m_Name = Name;
            }
        }
    }

    // Animal speed
    public float Speed { get; set; }

    public abstract void move();

    public abstract void jump();

    // Spawn animal at specified position
    public abstract void spawn(Vector3 position);

    // Spawn animal at origin
    public void spawn()
    {
        spawn(Vector3.zero);
    }
}
