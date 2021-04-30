using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    [SerializeField]
    private int _lives = 3;

    [SerializeField]
    private float _velocity = 10;

    [SerializeField]
    private GameManager myGameManager;

    [SerializeField]
    private UIManager _myUIManager;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        _myUIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _lives = 3;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Pipe")
        {
            myGameManager.isRunning = false;
            transform.position = new Vector3(0, 0, 0);
            _rigidBody.gravityScale = 0;
            _rigidBody.velocity = new Vector2(0, 0);
            Destroy(other.transform.parent.gameObject);
            _lives -= 1;

            if (_lives == 0)
            {
                this.gameObject.SetActive(false);
            }
        }
        else if (other.tag == "PipesPair")
        {
            _myUIManager.UpdateScore();
        }
    }
}
