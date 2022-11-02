using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class MainManager : MonoBehaviour
{
    // ENCAPSULATION
    // Singleton: Instance is the only instance of the class.
    public static MainManager Instance { get; private set; }

    // ENCAPSULATION
    private int m_NumberOfAnimals;
    public int NumberOfAnimals
    {
        get
        {
            return m_NumberOfAnimals;
        }
        set
        {
            if (value < 1)
            {
                Debug.Log("Number of animals has to be greater 0");
            }
            else if (value > 99)
            {
                Debug.Log("Number of animals has to be greater 0");
            }
            else
            {
                m_NumberOfAnimals = value;
            }
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetNumberOfAnimals(string input)
    {
        int n;
        bool success = int.TryParse(input, out n);
        if (success)
        {
            if (n < 1)
            {
                n = 1;
            }
            else if (n > 99)
            {
                n = 99;
            }
            NumberOfAnimals = n;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
