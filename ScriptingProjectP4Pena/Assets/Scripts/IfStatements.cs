using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TempatureTest();

       // coffeeTemperature -= Time.deltaTime * 5f;
    }


    void TempatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {

            // ... do this.
            print("Coffee is too cold.");
        }
        // Iff it isn't, but the coffee temperature is lless than the coldest drinking temperature...
        else if(coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {

            // ... do this.
            print("Coffee is just right.");
        }
    }
}