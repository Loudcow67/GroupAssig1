using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEditor.Experimental.SceneManagement;
using UnityEditor.PackageManager;
using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "BuildSquare" || hitInfo.collider.gameObject.tag == "Prefab")
                {
                    GetComponent<PrefabFactory>().PlaceObject(hitInfo.point);
                    ICommand command = new PlaceObjectCommand(hitInfo.point);
                    CommandInvoker.AddCommand(command);
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

    //public void PlaceObject(Vector3 clickPoint)
    //{
    //    PrefabFactory prefabFactory = GetComponent<PrefabFactory>();
    //
    //    var finalPosition = clickPoint;
    //    GameObject gameObject = Instantiate(prefabFactory.prefabs[prefabFactory.chosenPrefab]);
    //    gameObject.transform.position = finalPosition + new Vector3(0f, 1.5f, 0f);
    //}
}