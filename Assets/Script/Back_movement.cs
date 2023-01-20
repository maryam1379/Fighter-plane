using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_movement : MonoBehaviour
{
   
    public Renderer meshRenderer;
    public float speed = 0.01f;

    void Start()
    {
        
    }

    void Update()
    {

      meshRenderer.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);

    }
}
