
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicObject : MonoBehaviour
{
    public string name;
    public float PosZ ;
    public GameObject obj;

    public void savePosition()
    {

        Transform CurrentPlayerPosition = obj.transform;

        PlayerPrefs.SetFloat("PosX" + name, CurrentPlayerPosition.position.x);
        PlayerPrefs.SetFloat("PosY" + name, CurrentPlayerPosition.position.y);
    }

    public void loadPosition()
    {

        Transform CurrentPlayerPosition = obj.transform;

        Vector3 PlayerPosition = new Vector3(PlayerPrefs.GetFloat("PosX" + name),
                        PlayerPrefs.GetFloat("PosY" + name), PosZ);

        CurrentPlayerPosition.position = PlayerPosition;
    }

}

