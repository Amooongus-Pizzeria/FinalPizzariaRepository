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
        CalculateDistanceBetweenParentAndChild();
    }
    private void CalculateDistanceBetweenParentAndChild()
    {
        if (parentObject != null)
        {
            for (int i = 0; i < parentObject.transform.childCount; i++)
            {
                Transform child = parentObject.transform.GetChild(i);

                float distance = Vector3.Distance(parentObject.transform.position, child.position);

                Debug.Log("Distance between " + parentObject.name + " and " + child.name + ": " + distance);
            }
        }
        else
        {
            Debug.LogError("ParentObject not found!");
        }
    }
    
}
