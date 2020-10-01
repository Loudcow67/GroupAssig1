using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEditor.Experimental.SceneManagement;
using UnityEditor.PackageManager;
using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
    public GameObject[] prefabs;

    Camera c;
    int chosenPrefab = 0;

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
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "BuildSquare" || hitInfo.collider.gameObject.tag == "Prefab")
                {
                    PlaceObject(hitInfo.point);
                }
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Prefab")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    private void PlaceObject(Vector3 clickPoint)
    {
        var finalPosition = clickPoint;
        GameObject gameObject = Instantiate(prefabs[chosenPrefab]);
        gameObject.transform.position = finalPosition + new Vector3(0f, 1.5f, 0f);
    }
}