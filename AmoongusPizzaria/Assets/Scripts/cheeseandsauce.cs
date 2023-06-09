using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheeseandsauce : MonoBehaviour
{
    public GameObject interactObject;
    public Transform parentObject;
    public SpriteRenderer spriteRenderer;
    public Sprite containerObject;
    public Sprite placedObject;
    public float scalingSize;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        this.gameObject.GetComponent<SpriteRenderer>().sprite = containerObject;

    }

    // Update is called once per frame
    void Update()
    {
        if (interactObject != null && interactObject.GetComponent<Collider2D>().bounds.Intersects(spriteRenderer.bounds)){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = placedObject;
            //this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5;

            SpreadOut();

                    // Make the parent object the new parent of the object
                    this.gameObject.transform.SetParent(parentObject);

                    // Reset the position of the dragging object relative to the parent object
                    //draggingObject.transform.localPosition = initialPosition; // it would set the local position to the intial position - middle of the gameobject then

                    // Enable the parent object's movement script
                    parentObject.GetComponent<MoveParentObject>().enabled = true;
        }
    }

    private void SpreadOut() {

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite = placedObject){
            this.gameObject.transform.localScale = new Vector3(scalingSize, scalingSize, scalingSize);
        }
    }
}
