using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _pipes;

    public float canSpawn = 0.0f;
    private readonly float _spawnRate = 1.0f;

    [SerializeField]
    private GameManager _myGameManager;

    private void Update()
    {
        if (_myGameManager.isRunning && canSpawn < Time.time)
        {
            float randomY = Random.Range(-2.5f, 0.5f);
            Instantiate(_pipes, new Vector3(6.25f, randomY, 0), Quaternion.identity);
            canSpawn = Time.time + _spawnRate;
        }
    }
}