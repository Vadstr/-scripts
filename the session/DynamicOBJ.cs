using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicOBJ : MonoBehaviour
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

            PlayerPrefs.SetFloat("PosX1", CurrentPlayerPosition.position.x);
            PlayerPrefs.SetFloat("PosY1", CurrentPlayerPosition.position.y);
        }

        public void loadPosition()
        {

            Transform CurrentPlayerPosition = this.gameObject.transform;

            Vector2 PlayerPosition = new Vector2(PlayerPrefs.GetFloat("PosX1"),
                        PlayerPrefs.GetFloat("PosY1"));

            CurrentPlayerPosition.position = PlayerPosition;
        }
    }
