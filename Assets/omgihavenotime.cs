using UnityEngine;

public class omgihavenotime : MonoBehaviour
{
    private gameManager GameManager;
    private void Awake()
    {
        GameManager = FindAnyObjectByType<gameManager>();
    }

    public void char1()
    {
        gameManager.character = 0;
    }

    public void char2()
    {
        gameManager.character = 1;
    }
}
