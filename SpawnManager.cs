using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _pipes;

    [SerializeField]
    private GameManager _myGameManager;

    public void StartSpawning()
    {
        StartCoroutine(EnemySpawnRoutine());
    }

    IEnumerator EnemySpawnRoutine()
    {
        while (_myGameManager.isRunning)
        {
            float randomY = Random.Range(-2.5f, 0.5f);
            Instantiate(_pipes, new Vector3(6.25f, randomY, 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
