using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5.0f;
    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);

        if (transform.position.x < -9.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
