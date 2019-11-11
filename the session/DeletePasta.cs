using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeletePasta : MonoBehaviour
{
    

    void FixedUpdate()
    {
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
            Score.all += 1;
        }
    }

    private void OnTriggerStay2D(Collider2D Other)
    {
        if (Other.tag == "Pol")
        {
            Destroy(gameObject);
            Score.scoreAmount += 1;
            Score.all += 1;
        }
    }
}
