using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Spawner : MonoBehaviour
{
    public GameObject[] plane;

    void Start()
    {
            StartCoroutine(SpawnPlanes());
    }

    void Update()
    {
        
    }

    void Planes()
    {
            int rand = Random.Range(0,plane.Length);
            float randXPos= Random.Range(-1.92f,1.92f);
            Instantiate(plane[rand], new Vector3(randXPos, transform.position.y,transform.position.z) ,Quaternion.Euler(0,0,0));
        
    }

    IEnumerator SpawnPlanes() {
       while(true){
             yield return new WaitForSeconds(4);
               Planes();
       }
       
    }
}
