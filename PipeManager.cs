using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField]
    private float _speed = 7.5f;

    [SerializeField]
    private GameManager _myGameManager;

    private void Start()
    {
        _myGameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void Update()
    {
        if (_myGameManager.isRunning)
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }


        if (transform.position.x < -15.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
