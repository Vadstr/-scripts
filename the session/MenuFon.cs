
using System.Collections;
using UnityEngine;

public class MenuFon : MonoBehaviour
{
    public GameObject[] pasta;
    private float[] Ring = {15.0f, -15.0f};

    private void Start()
    {
        
        StartCoroutine(Spawn);
        
    }

    IEnumerator Spawn
    {
        get
        {
            while (true)
            {
                Instantiate(
                    pasta[Random.Range(0, pasta.Length)],
                    new Vector3(Ring[Random.Range(0,Ring.Length)], Random.Range(-4.5f, 2.5f), 85f),
                    Quaternion.Euler(new Vector2(0, 0))
                );
                yield return new WaitForSeconds(0.7f);
            }
        }
    }
}
