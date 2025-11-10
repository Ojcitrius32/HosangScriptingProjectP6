using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFStatments : MonoBehaviour
{
    float coffeTempertaure = 100f;
    float hotLimitTemperature = 75;
    float coldLimitTempature = 40;


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
        coffeTempertaure -= Time.deltaTime * 1f;

    }
    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)


        {
            print("Coffee is too hot.");
        }
    }
   }
{ 
    //test
}


