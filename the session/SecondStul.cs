using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondStul : MonoBehaviour
{
    public GameObject Stul;
    public Vector2 Vectorr;

    private void Start()
    {
        loadPosition();
        Application.targetFrameRate = 60;

    }


    void Update()
    {
            savePosition();
            loadPosition();
    }
    public void savePosition()
    {

        Transform CurrentPlayerPosition = this.gameObject.transform;

        PlayerPrefs.SetFloat("PosX2", CurrentPlayerPosition.position.x);
        PlayerPrefs.SetFloat("PosY2", CurrentPlayerPosition.position.y);
    }

    public void loadPosition()
    {

        Transform CurrentPlayerPosition = this.gameObject.transform;

        Vector2 PlayerPosition = new Vector2(PlayerPrefs.GetFloat("PosX2"),
                    PlayerPrefs.GetFloat("PosY2"));

        CurrentPlayerPosition.position = PlayerPosition;
    }
}

