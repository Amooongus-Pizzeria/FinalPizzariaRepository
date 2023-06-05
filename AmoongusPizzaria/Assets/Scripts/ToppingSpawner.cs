using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToppingSpawner : MonoBehaviour
{
    public GameObject toppingOriginal;
    public Transform toppingParent;


    // Update is called once per frame
    void OnMouseDown()
    {
        createTopping();
    }

    void createTopping()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePos.x);
        Debug.Log(mousePos.y);

        //GameObject toppingClone = Instantiate(toppingOriginal, new Vector3(-263, -144, 0), Quaternion.identity);


        GameObject toppingClone = Instantiate(toppingOriginal, toppingParent, true);


        toppingClone.GetComponent<SpriteRenderer>().sortingOrder = 5; //random # for testing temporarily
        //toppingClone.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        
    }
}
