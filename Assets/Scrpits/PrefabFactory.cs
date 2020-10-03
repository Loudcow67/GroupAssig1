using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabFactory : MonoBehaviour
{

    public GameObject[] prefabs;

    Camera c;
    public int chosenPrefab = 0;

    void Start()
    {
        c = GetComponent<Camera>();
        if (prefabs.Length == 0)
        {
            Debug.LogError("You haven't selected a Prefab");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            chosenPrefab++;
            if (chosenPrefab >= prefabs.Length)
            {
                chosenPrefab = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            chosenPrefab--;
            if (chosenPrefab < 0)
            {
                chosenPrefab = prefabs.Length - 1;
            }
        }
    }
}
