﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePlacer : MonoBehaviour
{
    Camera cam;
    RaycastHit HitInfo;
    public Transform Cube;

    private void Awake()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out HitInfo, Mathf.Infinity))
            {
                ICommand command = new PlaceObjectCommand(HitInfo.point, Cube);
                CommandInvoker.AddCommand(command);
            }
        }
    }
}
