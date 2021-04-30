using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Player _player;

    private Rigidbody2D _rigidBodyPlayer;

    public bool isRunning = false;
    public bool gameOver = true;

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
        if (!isRunning && Input.GetKeyDown(KeyCode.Space))
        {
            _player.gameObject.SetActive(true);
            isRunning = true;
            _UIManager.HideInstructions();

            if (gameOver)
            {
                NewGame();
            }

            if (_rigidBodyPlayer != null)
            {
                _rigidBodyPlayer.gravityScale = 2.75f;
            }
            _mySpawnManager.canSpawn = Time.time + 1.5f;
        }
    }

    public void GameOver()
    {
        _UIManager.DisplayScore();
        _player.lives = 3;
        gameOver = true;
    }

    private void NewGame()
    {
        gameOver = false;
        _player.lives = 3;
        _UIManager.HideScore();
        _UIManager.ResetScore();
        DestroyPipesOnNewGame();
    }

    private void DestroyPipesOnNewGame()
    {
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("PipesPair");
        foreach (GameObject obj in allObjects)
        {
            Destroy(obj);
        }
    }
}