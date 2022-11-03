using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private Animal[] Animals;
    [SerializeField]
    private int NumberOfAnimals;

    // Start is called before the first frame update
    void Start()
    {
        // Get number of animals from title screen input
        NumberOfAnimals = MainManager.Instance.NumberOfAnimals;
        StartCoroutine(SpawnAnimals());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnAnimals()
    {
        for (int i = 0; i < NumberOfAnimals; i++)
        {
            yield return new WaitForSeconds(1);
            GetRandomAnimal().Spawn();
        }
    }

    private Animal GetRandomAnimal()
    {
        int randomIndex = Random.Range(0, Animals.Length);
        return Animals[randomIndex];
    }
}
