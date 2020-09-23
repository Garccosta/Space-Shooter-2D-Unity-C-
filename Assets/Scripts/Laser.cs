using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8f;

    Vector3 direction = new Vector3(0, 1, 0);

    void Update()
    {
        transform.Translate(direction * _speed * Time.deltaTime);

        if(transform.position.y > 8f)
        {
            Destroy(this.gameObject);
        }
    }
}
