using System;
using UnityEngine;

public class ToppingDistanceCalculator : MonoBehaviour
{
    public GameObject parentObject;
    private void Start()
    {
        String parentObjectName = this.parentObject.name;
        parentObject = GameObject.Find(parentObjectName); // Replace "ParentObject" with the name of your parent GameObject

    }
    private void Update()
    {
        CalculateDistanceBetweenToppings();
    }
    private void CalculateDistanceBetweenToppings()
    {
        if (parentObject != null)
        {
            Transform[] children = parentObject.GetComponentsInChildren<Transform>();

            for (int i = 0; i < children.Length; i++)
            {
                for (int j = i + 1; j < children.Length; j++)
                {
                    float distance = Vector3.Distance(children[i].position, children[j].position);

                    Debug.Log("Distance between " + children[i].name + " and " + children[j].name + ": " + distance);
                }
            }
        }
        else
        {
            Debug.LogError("ParentObject not found!");
        }

    }
}
