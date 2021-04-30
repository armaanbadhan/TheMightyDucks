using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidBody;

    public int lives = 3;

    [SerializeField]
    private float _velocity = 10;

    [SerializeField]
    private GameManager myGameManager;

    [SerializeField]
    private UIManager _myUIManager;

    void Start()
    {
        _myUIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _rigidBody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && myGameManager.isRunning)
        {
            _rigidBody.velocity = new Vector2(0, _velocity);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag is "Pipe")
        {
            myGameManager.isRunning = false;
            transform.position = new Vector3(0, 0, 0);
            _rigidBody.gravityScale = 0;
            _rigidBody.velocity = new Vector2(0, 0);
            Destroy(other.transform.parent.gameObject);
            lives -= 1;

            _myUIManager.UpdateLivesImage(lives);

            if (lives == 0)
            {
                this.gameObject.SetActive(false);
                myGameManager.GameOver();
            }
        }
        else if (other.tag is "PipesPair")
        {
            _myUIManager.UpdateScore();
        }
    }
}
