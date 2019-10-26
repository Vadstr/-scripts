using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : DynamicObject
{
    public GameObject obj1;
    public GameObject obj2;
    DynamicObject Dobj1 = new DynamicObject();
    DynamicObject Dobj2 = new DynamicObject();

    void Start()
    {
        
        Dobj1.name = "stul1";
        Dobj2.name = "stul2";
        Dobj1.obj = obj1;
        Dobj2.obj = obj2;
        Dobj1.loadPosition();
        Dobj2.loadPosition();

    }


    void Update()
    {
        Dobj1.savePosition();
        Dobj2.savePosition();
    }
}
