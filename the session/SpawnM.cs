using System.Collections;
using UnityEngine;

public class SpawnM : MonoBehaviour
{
    public GameObject pasta;
    private int HowMuchPasta = 20;

    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        for (int i = 0;i< HowMuchPasta; i++)
        {
            Instantiate(
                pasta,
                new Vector2(Random.Range(-5, 6), 6f),
                Quaternion.Euler(new Vector2(0, 0))
            );
            yield return new WaitForSeconds(1.5f);
        }
        
    }
    
}
