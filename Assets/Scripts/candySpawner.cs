using System.Collections;
using UnityEngine;

public class candySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] candyFab;
    
    [SerializeField] private int random;


    private void Update()
    {
        transform.position = new Vector3(Random.Range(-5f, 6f), transform.position.y, transform.position.z);
    }

    private void SpawnACandy()
    {
        random = Random.Range(0, 101);
        if (random < 30)
        {
            InstantiateCandy(0);
            return;
        }
        else if (random < 50)
        {
            InstantiateCandy(1);
            return;
        }
        else if (random < 60)
        {
            InstantiateCandy(2);
            return;
        }
        else if (random < 75)
        {
            InstantiateCandy(3);
            return;
        }
        else if (random < 90)
        {
            InstantiateCandy(4);
            return;
        }
        else if (random < 100)
        {
            InstantiateCandy(5);
            return;
        }
    }

    private void InstantiateCandy(int candy)
    {
        GameObject candyUHH = Instantiate(candyFab[candy]);
        candyUHH.transform.position = transform.position;
    }

    private void OnEnable()
    {
        gameManager.spawnCandy += SpawnACandy;
    }

    private void OnDisable()
    {
        gameManager.spawnCandy -= SpawnACandy;
    }
}
