using UnityEngine;
using System;
using UnityEngine.SocialPlatforms.Impl;

public class candyScript : MonoBehaviour
{
    public static event Action<int> candyGet;
    [SerializeField] private int scoreGain;
    [SerializeField] private float speed;

    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            candyGet?.Invoke(scoreGain);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }
}
