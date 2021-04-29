using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    [SerializeField]
    private float _velocity = 10;

    public bool isRunning = false;

    void Start()
    {
        isRunning = false;
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.gravityScale = 0;
        transform.position = new Vector3(0, 0, 0);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isRunning)
        {
            _rigidBody.velocity = new Vector2(0, _velocity);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
