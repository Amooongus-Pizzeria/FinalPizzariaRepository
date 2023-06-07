using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheeseandsauce : MonoBehaviour
{
    public GameObject interactObject;
    public SpriteRenderer spriteRenderer;
    public Sprite placedObject;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (interactObject != null && interactObject.GetComponent<Collider2D>().bounds.Intersects(spriteRenderer.bounds))
            this.gameObject.GetComponent<SpriteRenderer>().sprite = placedObject;
            this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
    }
}
