using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public GameObject planet;
    [SerializeField] private Vector3 minScale;
    [SerializeField] private Vector3 maxScale;
    [SerializeField] private Material[] materials;


    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = minScale;
        if (materials.Length != 0)
        {
            Material material = materials[Random.Range(0, materials.Length)];
            planet.GetComponent<SpriteRenderer>().material = materials[Random.Range(0, materials.Length)];
        }
    }

    void Update()
    {
        if (transform.localScale.x < maxScale.x)
        {
            transform.localScale += new Vector3(0.001F, 0.001F, 0);
        }
        else
        {
            Destroy(planet);
        }
    }

    public void OnMouseUpAsButton()
    {
        Destroy(planet);
    }
}
