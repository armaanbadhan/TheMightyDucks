using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Player _player;
    private Rigidbody2D _rigidBodyPlayer;

    public bool isRunning = false;

    [SerializeField]
    private SpawnManager _mySpawnManager;

    void Start()
    {
        _rigidBodyPlayer = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isRunning)
        {
            isRunning = true;
            _rigidBodyPlayer.gravityScale = 2.75f;
            _mySpawnManager.StartSpawning();
        }
    }
}
