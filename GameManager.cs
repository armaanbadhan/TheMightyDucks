using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Player _player;
    private Rigidbody2D _rigidBodyPlayer;

    void Start()
    {
        _rigidBodyPlayer = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        _rigidBodyPlayer.gravityScale = 0;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_player.isRunning)
        {
            _player.isRunning = true;
            _rigidBodyPlayer.gravityScale = 2.75f;
        }
    }
}
