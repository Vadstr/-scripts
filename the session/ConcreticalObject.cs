using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreticalObject : DynamicObject
{
    public GameObject obj1;
    DynamicObject Dobj1 = new DynamicObject();
    public string Name;
    public float PositionZ;

    void Start()
    {

        Dobj1.name = Name;
        Dobj1.obj = obj1;
        Dobj1.loadPosition();
        Dobj1.PosZ = PositionZ;

    }


    void Update()
    {
        Dobj1.savePosition();
    }
}
