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

    [SerializeField]
    private UIManager _UIManager;

    void Start()
    {
        _rigidBodyPlayer = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        _rigidBodyPlayer.gravityScale = 0;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isRunning)
        {
            _player.gameObject.SetActive(true);
            isRunning = true;
            _UIManager.HideInstructions();
            if (_rigidBodyPlayer != null)
            {
                _rigidBodyPlayer.gravityScale = 2.75f;
            }
            _mySpawnManager.canSpawn = Time.time + 1.0f;
        }
    }
}
