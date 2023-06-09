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
        //Debug.Log(mousePos.x);
        //Debug.Log(mousePos.y);

        //GameObject toppingClone = Instantiate(toppingOriginal, mousePos, Quaternion.Euler(new Vector3(90, Random.Range(0, 360), 0)), toppingParent);

        GameObject toppingClone = Instantiate(toppingOriginal, toppingParent, true);



        toppingClone.GetComponent<SpriteRenderer>().sortingOrder = 5; //random # for testing temporarily
        //toppingClone.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        
    }
}
