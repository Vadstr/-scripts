using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnM : MonoBehaviour
{
    public GameObject pasta;
    public int ScenNumber;
    public int HowMuchPasta;

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
        //SceneManager.LoadScene(ScenNumber);

    }
    
}
