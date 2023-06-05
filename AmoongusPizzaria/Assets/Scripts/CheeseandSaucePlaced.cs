using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseandSaucePlaced : MonoBehaviour
{
    public Sprite placedItem;
    public Transform parentObject;
    public LayerMask targetLayer;

    private GameObject draggingObject;
    private Vector3 initialPosition;


    private void OnMouseDown()
    {
        // Check if the mouse is over a game object with the target layer
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, Mathf.Infinity, targetLayer);
        if (hit.collider != null)
        {
            // Set the dragging object and its initial position
            draggingObject = hit.collider.gameObject;
            initialPosition = draggingObject.transform.position;
        }
    }

    private void OnMouseDrag()
    {
        // Check if there is a dragging object
        if (draggingObject != null)
        {
            // Move the dragging object to the mouse position
            draggingObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    private void OnMouseUp()
    {
        // Check if there is a dragging object
        if (draggingObject != null)
        {
            // Check if the dragging object is over the parent object
            if (parentObject.GetComponent<Collider2D>().bounds.Contains(draggingObject.transform.position))
            {
                //replace image with spread out version
                this.draggingObject.GetComponent<SpriteRenderer>().sprite = placedItem;

                // Make the parent object the new parent of the dragging object
                draggingObject.transform.SetParent(parentObject);

                // Reset the position of the dragging object relative to the parent object
                //draggingObject.transform.localPosition = initialPosition; // it would set the local position to the intial position - middle of the gameobject then

                // Enable the parent object's movement script
                parentObject.GetComponent<MoveParentObject>().enabled = true;

            }
            else
            {
                // Reset the position of the dragging object to its initial position
                draggingObject.transform.position = initialPosition; // drags it back to where it needs to go
            }

            // Reset the dragging object and initial position
            draggingObject = null;
            initialPosition = Vector3.zero;
        }
    }
}
