using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreticalObject : DynamicObject
{
    public GameObject obj1;
    public string NameObj;
    public float PositionZ;
    DynamicObject Dobj1 = new DynamicObject();

    void Start()
    {

        Dobj1.NAME = NameObj;
        Dobj1.OBJ = obj1;
        Dobj1.loadPosition();
        Dobj1.POSZ = PositionZ;

    }


    void Update()
    {
        Dobj1.savePosition();
    }
}
