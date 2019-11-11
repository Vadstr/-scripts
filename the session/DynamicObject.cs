
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicObject : MonoBehaviour
{

    private string Name;
    private float Posz;
    private GameObject Obj; 

    public string NAME {
        get {
            return Name;
        }
        set {
            Name = value;
        }

    }


    public GameObject OBJ
    {
        get
        {
            return Obj;
        }
        set
        {
            Obj = value;
        }

    }

    public float POSZ
    {
        get
        {
            return Posz;
        }
        set
        {
            Posz = value;
        }

    }

    public void savePosition()
    {

        Transform CurrentPlayerPosition = Obj.transform;

        PlayerPrefs.SetFloat("PosX" + Name, CurrentPlayerPosition.position.x);
        PlayerPrefs.SetFloat("PosY" + Name, CurrentPlayerPosition.position.y);
    }


    public void loadPosition()
    {

        Transform CurrentPlayerPosition = Obj.transform;

        Vector3 PlayerPosition = new Vector3(PlayerPrefs.GetFloat("PosX" + Name),
                        PlayerPrefs.GetFloat("PosY" + Name), Posz);

        CurrentPlayerPosition.position = PlayerPosition;
    }

}

