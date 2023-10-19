using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static int character;
    [SerializeField] private GameObject[] chracters;


    public static int score = 0;

    public static event Action spawnCandy;

    [SerializeField] private int candyAmount;
    private UIScript uiScript;
    [SerializeField] private GameObject gameOverUI;

    Coroutine myCoroutine;
    private void AddScore(int gain)
    {
        score += gain;
        uiScript.SetText(score);
        Debug.Log(score);
    }

    IEnumerator SpawnACandy()
    {
        yield return new WaitForSeconds(3);
        for (int i = 0; i < candyAmount;  i++)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(1f, 3f));
            Debug.Log("Spawned Candy: " + i);
            spawnCandy?.Invoke();
        }
        yield return new WaitForSeconds(2);
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
        uiScript.setFinalText(score);

    }

    private void Awake()
    {
        
        uiScript = FindObjectOfType<UIScript>();
        myCoroutine = StartCoroutine("SpawnACandy");
    }
    public void setActive(int chaarra)
    {
        chracters[chaarra].SetActive(true);
    }
    private void OnEnable()
    {
        candyScript.candyGet += AddScore;
    }
    private void OnDisable()
    {
        candyScript.candyGet -= AddScore;
    }
}
