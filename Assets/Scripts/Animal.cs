using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Abstract parent class for all animals.
public abstract class Animal : MonoBehaviour
{
    private float xRange = 15;
    private float zRange = 15;
    private float yPosition = 0f;

    // ENCAPSULATION
    private string m_Name = "Animal";
    // Animal name. Name length may not exceed 10 characters.
    public string AnimalName
    {
        get { return m_Name; }
        set { 
            if (value.Length > 10)
            {
                Debug.Log("You can't use animal names with more than 10 characters!");
            }
            else
            {
                m_Name = value;
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
    // Spawn animal at random position
    public virtual void Spawn()
    {
        Spawn(RandomPosition());
    }

    // Random position in visible area.
    protected Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-xRange, xRange), yPosition, Random.Range(-zRange, zRange));
    }
}
