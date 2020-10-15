using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjectCommand : ICommand
{
    Vector3 position;


    public PlaceObjectCommand(Vector3 position)
    {
        this.position = position;
    }

    public void Execute()
    {
        PrefabFactory prefabFactory = new PrefabFactory();
        prefabFactory.PlaceObject(position);
    }

    public void Undo()
    {
        PrefabFactory prefabFactory = new PrefabFactory();
        prefabFactory.removeObject(position);
    }
}
