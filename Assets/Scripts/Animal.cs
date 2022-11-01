using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Abstract parent class for all animals.
public abstract class Animal : MonoBehaviour
{
    private float timeSinceSpawn = 0.0f;

    // ENCAPSULATION
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

    // ENCAPSULATION
    // Animal speed
    public float Speed { get; set; }

    // ABSTRACTION
    public abstract void Move();

    // ABSTRACTION
    // Spawn animal at specified position
    public virtual void Spawn(Vector3 position)
    {
        Instantiate(this, position, this.transform.rotation);
    }

    // ABSTRACTION
    // POLYMORPHISM
    // Spawn animal at origin
    public virtual void Spawn()
    {
        Spawn(Vector3.zero);
    }
}
