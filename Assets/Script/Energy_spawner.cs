using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy_spawner : MonoBehaviour
{
      public GameObject energyPrefabs;

    void Start()
    {
        StartCoroutine(EnergySpawner());
    }

  

    void EnergySpawn()
    {
        float rand = Random.Range(-1.92f,1.92f);
        Instantiate(energyPrefabs, new Vector3(rand,transform.position.y,transform.position.z),Quaternion.identity);
    }


    IEnumerator EnergySpawner() {
        while (true) {
            int time = Random.Range(5,15);
            yield return new WaitForSeconds(time);
            EnergySpawn();
        }
    }
}
