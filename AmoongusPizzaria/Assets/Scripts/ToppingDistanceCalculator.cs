using System;
using UnityEngine;
using UnityEngine.UI;

public class ToppingDistanceCalculator : MonoBehaviour
{
    public GameObject parentObject;
    public int pairCount = 0;
    public float totalDistance = 0f;
    public float averageDistance;

    public bool isEvenlySpaced;

    //CalculateScoring scoringScript;

    public double pizzaMoney = 12.55;

    private void Start()
    {
        String parentObjectName = this.parentObject.name;
        parentObject = GameObject.Find(parentObjectName); // Replace "ParentObject" with the name of your parent GameObject

    }
    private void Update()
    {
        // CalculateDistanceBetweenToppings();
    }
    public void CalculateDistanceBetweenToppings()
    {
        if (parentObject != null)
        {
            Transform[] children = parentObject.transform.GetComponentsInChildren<Transform>();


            for (int i = 0; i < children.Length; i++)
            {
                for (int j = i + 1; j < children.Length; j++)
                {   
                    float distance = Vector3.Distance(children[i].position, children[j].position);

                    totalDistance += distance;
                    pairCount++;

                    averageDistance = totalDistance / pairCount;

                    Debug.Log("Distance between " + children[i].name + " and " + children[j].name + ": " + distance);
                    Debug.Log("Average distance between child objects: " + averageDistance);

                }
            }
        }
        else
        {
            Debug.LogError("ParentObject not found!");
        }

    }

    public void calculateScoring()
    {
        if(averageDistance > 0.35 && averageDistance < 0.6)
        {
            isEvenlySpaced = true;
        }
    }

    public void calculateMoneyEarned()
    {
        if (!isEvenlySpaced)
        {
            pizzaMoney *= .8;
        }

    }   

    public void returnTotalMoney()
    {
        Debug.Log(pizzaMoney);
    }
}
