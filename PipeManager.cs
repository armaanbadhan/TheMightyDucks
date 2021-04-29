using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField]
    private float _speed = 7.5f;

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);

        if (transform.position.x < -15.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
