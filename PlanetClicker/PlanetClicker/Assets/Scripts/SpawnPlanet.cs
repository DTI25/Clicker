using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanet : MonoBehaviour
{
    public GameObject planet;
    void Update()
    {
        StartCoroutine(Spawn());   
    }

    IEnumerator Spawn() {
        Instantiate(planet, new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(-4.5f, 4.5f), 0), Quaternion.identity);
        yield return new WaitForSeconds(5f);
    }
}
