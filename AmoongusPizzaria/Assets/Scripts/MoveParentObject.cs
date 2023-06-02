using UnityEngine;

public class MoveParentObject : MonoBehaviour
{
    private void OnMouseDrag()
    {
        // Move the parent object with the mouse movement
        Vector3 mouseDelta = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
        transform.position += mouseDelta;
    }
}
