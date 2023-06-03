using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCursor : MonoBehaviour
{
    [SerializeField]
    private Texture2D ReleasedState;
    [SerializeField]
    private Texture2D PressedState;
    // [SerializeField]
    private Vector2 _hotspot;

    [SerializeField]
    private CursorMode _cursorMode = CursorMode.Auto;

    void Start()
    {
        _hotspot = new Vector2(ReleasedState.width / 2, ReleasedState.height / 2);
        Cursor.SetCursor(ReleasedState, _hotspot, _cursorMode);
    }

    // Update is called once per frame
    void Update() { }
/*    {
        if(Input.GetMouseButtonDown(0))
        {
          Cursor.SetCursor(PressedState, _hotspot, _cursorMode);
        }
        if (Input.GetMouseButtonUp(0))
        {
          Cursor.SetCursor(ReleasedState, _hotspot, _cursorMode);
        }
    */


/*    private void OnMouseUp()
    {
        Cursor.SetCursor(ReleasedState, _hotspot, _cursorMode);
    }

    private void OnMouseDown()
    {
        Cursor.SetCursor(PressedState, _hotspot, _cursorMode);
    }*/
}
