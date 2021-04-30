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

    [SerializeField]
    private GameObject[] _clouds;

    private void Start()
    {
        StartCoroutine(CloudSpawnRoutine());
    }

    private void Update()
    {
        if (_myGameManager.isRunning && canSpawn < Time.time)
        {
            float randomY = Random.Range(-2.5f, 0.5f);
            Instantiate(_pipes, new Vector3(6.25f, randomY, 0), Quaternion.identity);
            canSpawn = Time.time + _spawnRate;
        }
    }

    IEnumerator CloudSpawnRoutine()
    {
        while (true)
        {
            int randomPowerUp = Random.Range(0, 3);
            float randomY = Random.Range(0, 3.15f);
            float randomTime = Random.Range(1.0f, 2.0f);
            Instantiate(_clouds[randomPowerUp], new Vector3(9.0f, randomY, 0), Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }
    }
}