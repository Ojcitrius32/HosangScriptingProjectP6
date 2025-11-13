using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFStatments : MonoBehaviour
{
    float coffeeTemperture = 70f;
    float hotLimitTemperature = 50;
    float coldLimitTempature = 30;


    // Start is called before the first frame update
    void Start()//test
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();


        }
        coffeeTemperture -= Time.deltaTime * 1f;

    }
    void TemperatureTest()
    {
        if (coffeeTemperture > hotLimitTemperature)


        {
            print("Coffee is too hot.");
        }
        else if (coffeeTemperture < coldLimitTempature)
        {
            print("coffeeTemperture is too cold.");
        }
      
            else
        
        {
            print("Coffee is just right.");
        }
    }




}


