using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    [SerializeField]
    private float _velocity = 10;

    [SerializeField]
    private GameManager myGameManager;

    void Start()
    {
        myGameManager.isRunning = false;
        _rigidBody = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0, 0, 0);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && myGameManager.isRunning)
        {
            _rigidBody.velocity = new Vector2(0, _velocity);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
    }
}
