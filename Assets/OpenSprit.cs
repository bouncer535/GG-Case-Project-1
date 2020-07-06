using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSprit : MonoBehaviour
{
    List<int> Box;
    int Closed;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    // Start is called before the first frame update
   
    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(2);
        one.GetComponent<changeColor>().grey();
        // Code to execute after the delay
    }

    // Update is called once per frame
    public void choose()
    {
        one.GetComponent<changeColor>().green();
        StartCoroutine(ExecuteAfterTime());
        
        
        six.GetComponent<changeColor>().green();
        /*
        if(Closed != 0)
        {
            int tmp = 0;
            while(tmp==0)
            {
                
                tmp = 1;
            }
        }
        */
    }
}
