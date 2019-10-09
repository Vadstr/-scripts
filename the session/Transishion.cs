using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transishion : MonoBehaviour
{
    public int ScenNumber;
    public string Playertag;


    private void OnTriggerStay2D(Collider2D Other)
    {
        if (Other.tag == Playertag) {
            if (Input.GetKey(KeyCode.E)) {
                SceneManager.LoadScene(ScenNumber);

            }
        }
    }

}
