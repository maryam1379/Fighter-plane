using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_movment : MonoBehaviour
{
    public Transform transform;
    public float speed = 8f;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        transform.position -= new Vector3(0,speed * Time.deltaTime,0);
        if (transform.position.y <= -10) {
            Destroy(gameObject);
        }
    }
}
