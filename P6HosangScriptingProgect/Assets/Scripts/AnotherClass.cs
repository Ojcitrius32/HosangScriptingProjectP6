using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples = 40;
    public int bananas;

    private int sellotape;
    private int stapler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("fruit total; " +  answer);

    }
    private void PfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Suplies total:" + answer);
        
    }
}
