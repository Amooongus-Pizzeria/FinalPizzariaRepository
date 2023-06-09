using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateScoring : MonoBehaviour
{
    public double pizzaMoney = 12.55;

    public void totalPizzaMoney()
    {
        Debug.Log(pizzaMoney);
    }

    public double GetPizzaMoney()
    {
        return pizzaMoney;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
