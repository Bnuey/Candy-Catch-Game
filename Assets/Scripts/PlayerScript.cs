using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Vector2 move;
    [SerializeField] private float playerSpeed;

    private void Awake()
    {
        Inputs.Init(this);
    }
    public void Move(Vector2 direction)
    {
        move = direction;
    }

    private void Update()
    {
        transform.Translate(Vector3.right * (move.x * Time.deltaTime * playerSpeed), Space.Self);
    }
}
