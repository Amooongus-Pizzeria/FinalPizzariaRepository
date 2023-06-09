using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToppingDistanceCalculator : MonoBehaviour
{
    public GameObject parentObject;
    public GameObject red_SAUCE;
    public GameObject blue_SAUCE;
    public GameObject green_SAUCE;
    public GameObject cheese_SAUCE;

    // public Transform parentTransform;
    public int pairCount = 0;
    public float totalDistance = 0f;
    public float averageDistance;

    public bool isEvenlySpaced;

    //CalculateScoring scoringScript;

    public double pizzaMoney = 12.55;


    bool red_sauce = false;
    bool cheese = false;
    bool pepperoni = false;
    bool mushroom = false;
    bool olive = false;
    string order = "";

    public TextMeshProUGUI orderText;

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
        if(averageDistance > 0.35 && averageDistance < 0.7)
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

        if(red_sauce == true)
        {
            // if (parentObject.GetC)
             red_SAUCE = GameObject.Find("RedSauce");
            if (!red_SAUCE)
            {
                pizzaMoney *= .75;
            }
        }

        if (green_SAUCE == true)
        {
            // if (parentObject.GetC)
            green_SAUCE = GameObject.Find("GreenSauce");
            if (!green_SAUCE)
            {
                pizzaMoney *= .75;
            }
        }
        if (blue_SAUCE == true)
        {
            // if (parentObject.GetC)
            blue_SAUCE = GameObject.Find("BlueSauce");
            if (!blue_SAUCE)
            {
                pizzaMoney *= .75;
            }
        }
        if (cheese_SAUCE == true)
        {
            // if (parentObject.GetC)
            cheese_SAUCE = GameObject.Find("Cheese");
            if (!cheese_SAUCE)
            {
                pizzaMoney *= .75;
            }
        }

    }   

    public void returnTotalMoney()
    {
        Debug.Log(pizzaMoney);
    }

    public class BooleanGenerator
    {
        System.Random rnd;

        public BooleanGenerator()
        {
            rnd = new System.Random();
        }

        public bool NextBoolean()
        {
            return rnd.Next(0, 2) == 1;
        }
    }

    public void GenerateNewOrder()
    {
        BooleanGenerator boolGen = new BooleanGenerator();

        order = "";
        orderText.GetComponent<TextMeshProUGUI>().text = "Please make me a pizza with: \n" + order;

        red_sauce = boolGen.NextBoolean();
        cheese = boolGen.NextBoolean();
        pepperoni = boolGen.NextBoolean();
        mushroom = boolGen.NextBoolean();
        olive = boolGen.NextBoolean();

        printNewOrder(red_sauce, cheese, pepperoni, mushroom, olive);
    }

    //prints true items in list
    public void printNewOrder(bool r_s, bool ch, bool p, bool m, bool o)
    {
        if (r_s) { order = order + "\nRed Sauce"; }
        else { order = order + "\nGreen Sauce"; }
        if (ch) { order = order + "\nCheese"; }
        if (p) { order = order + "\nPepperoni"; }
        if (m) { order = order + "\nMushroom"; }
        if (o) { order = order + "\nOlive"; }
    }
}
