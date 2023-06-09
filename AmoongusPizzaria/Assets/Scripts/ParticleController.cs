using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public GameObject interactObject;
    public SpriteRenderer spriteRenderer;
    public ParticleSystem ps;
    public bool moduleEnabled;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ps = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        if (interactObject != null && interactObject.GetComponent<Collider2D>().bounds.Intersects(spriteRenderer.bounds))
        {
            var emission = ps.emission;
            emission.enabled = moduleEnabled;
            Debug.Log("emission");
        }
    }
}


