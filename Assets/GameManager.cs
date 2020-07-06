using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
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
    public GameObject sprite1;
    public GameObject sprite2;
    public GameObject sprite3;
    public GameObject sprite4;
    public GameObject sprite5;
    public GameObject sprite6;
    public GameObject sprite7;
    public GameObject sprite8;
    public GameObject sprite9;
    void Start()
    {
        Box = new List<int> { 0 };
        for (int i = 0; i < 8; i++)
        {
            Box.Add(0);
        }
        Closed = 9;
    }

    // Update is called once per frame
    IEnumerator ExecuteAfterTime(int searchNumber)
    {
        int isFind = 0;
        int i;
        int open = 0;
        for(i=0;i<2;i++)
        {
            if(i == 1)
            {
                open = 1;
            }
        
            if (Box[0]==0 && isFind == 0) //1. resim
            {
                one.GetComponent<changeColor>().green();
                yield return new WaitForSeconds(0.5f);
                one.GetComponent<changeColor>().grey();
                if(searchNumber == 1 && open == 1)
                {
                    Box[0] = 1;
                    isFind = 1;
                    sprite1.SetActive(true);
                }
            }
            if (Box[1] == 0 && isFind == 0)
            {
                two.GetComponent<changeColor>().green();
                yield return new WaitForSeconds(0.5f);
                two.GetComponent<changeColor>().grey();
                if (searchNumber == 2 && open == 1)
                {
                    Box[1] = 1;
                    isFind = 1;
                    sprite2.SetActive(true);
                }
            }
            if (Box[2] == 0 && isFind == 0)
            {
                three.GetComponent<changeColor>().green();
                yield return new WaitForSeconds(0.5f);
                three.GetComponent<changeColor>().grey();
                if (searchNumber == 3 && open == 1)
                {
                    Box[2] = 1;
                    isFind = 1;
                    sprite3.SetActive(true);
                }
            }
            if (Box[3] == 0 && isFind == 0)
            {
                four.GetComponent<changeColor>().green();
                yield return new WaitForSeconds(0.5f);
                four.GetComponent<changeColor>().grey();
                if (searchNumber == 4 && open == 1)
                {
                    Box[3] = 1;
                    isFind = 1;
                    sprite4.SetActive(true);
                }
            }
            if (Box[4] == 0 && isFind == 0)
            {
                five.GetComponent<changeColor>().green();
                yield return new WaitForSeconds(0.5f);
                five.GetComponent<changeColor>().grey();
                if (searchNumber == 5 && open == 1)
                {
                    Box[4] = 1;
                    isFind = 1;
                    sprite5.SetActive(true);
                }
            }
            if (Box[5] == 0 && isFind == 0)
            {
                six.GetComponent<changeColor>().green();
                yield return new WaitForSeconds(0.5f);
                six.GetComponent<changeColor>().grey();
                if (searchNumber == 6 && open == 1)
                {
                    Box[5] = 1;
                    isFind = 1;
                    sprite6.SetActive(true);
                }
            }
            if (Box[6] == 0 && isFind == 0)
            {
                seven.GetComponent<changeColor>().green();
                yield return new WaitForSeconds(0.5f);
                seven.GetComponent<changeColor>().grey();
                if (searchNumber == 7 && open == 1)
                {
                    Box[6] = 1;
                    isFind = 1;
                    sprite7.SetActive(true);
                }
            }
            if (Box[7] == 0 && isFind == 0)
            {
                eight.GetComponent<changeColor>().green();
                yield return new WaitForSeconds(0.5f);
                eight.GetComponent<changeColor>().grey();
                if (searchNumber == 8 && open == 1)
                {
                    Box[7] = 1;
                    isFind = 1;
                    sprite8.SetActive(true);
                }
            }
            if (Box[8] == 0 && isFind == 0)
            {
                nine.GetComponent<changeColor>().green();
                yield return new WaitForSeconds(0.5f);
                nine.GetComponent<changeColor>().grey();
                if (searchNumber == 9 && open == 1)
                {
                    Box[8] = 1;
                    isFind = 1;
                    sprite9.SetActive(true);
                }
            }
        }

        i = -1;
        while (isFind == 0)
        {
            i++;
            if (Box[i] == 0)
            {
                Debug.Log("sonuc");
                Debug.Log(i+1);
                
                searchNumber = i + 1;
                if (Box[0] == 0 && isFind == 0) //1. resim
                {
                    one.GetComponent<changeColor>().green();
                    yield return new WaitForSeconds(0.5f);
                    one.GetComponent<changeColor>().grey();
                    if (searchNumber == 1 && open == 1)
                    {
                        Box[0] = 1;
                        isFind = 1;
                        sprite1.SetActive(true);
                    }
                }
                if (Box[1] == 0 && isFind == 0)
                {
                    two.GetComponent<changeColor>().green();
                    yield return new WaitForSeconds(0.5f);
                    two.GetComponent<changeColor>().grey();
                    if (searchNumber == 2 && open == 1)
                    {
                        Box[1] = 1;
                        isFind = 1;
                        sprite2.SetActive(true);
                    }
                }
                if (Box[2] == 0 && isFind == 0)
                {
                    three.GetComponent<changeColor>().green();
                    yield return new WaitForSeconds(0.5f);
                    three.GetComponent<changeColor>().grey();
                    if (searchNumber == 3 && open == 1)
                    {
                        Box[2] = 1;
                        isFind = 1;
                        sprite3.SetActive(true);
                    }
                }
                if (Box[3] == 0 && isFind == 0)
                {
                    four.GetComponent<changeColor>().green();
                    yield return new WaitForSeconds(0.5f);
                    four.GetComponent<changeColor>().grey();
                    if (searchNumber == 4 && open == 1)
                    {
                        Box[3] = 1;
                        isFind = 1;
                        sprite4.SetActive(true);
                    }
                }
                if (Box[4] == 0 && isFind == 0)
                {
                    five.GetComponent<changeColor>().green();
                    yield return new WaitForSeconds(0.5f);
                    five.GetComponent<changeColor>().grey();
                    if (searchNumber == 5 && open == 1)
                    {
                        Box[4] = 1;
                        isFind = 1;
                        sprite5.SetActive(true);
                    }
                }
                if (Box[5] == 0 && isFind == 0)
                {
                    six.GetComponent<changeColor>().green();
                    yield return new WaitForSeconds(0.5f);
                    six.GetComponent<changeColor>().grey();
                    if (searchNumber == 6 && open == 1)
                    {
                        Box[5] = 1;
                        isFind = 1;
                        sprite6.SetActive(true);
                    }
                }
                if (Box[6] == 0 && isFind == 0)
                {
                    seven.GetComponent<changeColor>().green();
                    yield return new WaitForSeconds(0.5f);
                    seven.GetComponent<changeColor>().grey();
                    if (searchNumber == 7 && open == 1)
                    {
                        Box[6] = 1;
                        isFind = 1;
                        sprite7.SetActive(true);
                    }
                }
                if (Box[7] == 0 && isFind == 0)
                {
                    eight.GetComponent<changeColor>().green();
                    yield return new WaitForSeconds(0.5f);
                    eight.GetComponent<changeColor>().grey();
                    if (searchNumber == 8 && open == 1)
                    {
                        Box[7] = 1;
                        isFind = 1;
                        sprite8.SetActive(true);
                    }
                }
                if (Box[8] == 0 && isFind == 0)
                {
                    nine.GetComponent<changeColor>().green();
                    yield return new WaitForSeconds(0.5f);
                    nine.GetComponent<changeColor>().grey();
                    if (searchNumber == 9 && open == 1)
                    {
                        Box[8] = 1;
                        isFind = 1;
                        sprite9.SetActive(true);
                    }
                }
                isFind = 1;
            }
        }
        // Code to execute after the delay
    }

    // Update is called once per frame
    public void choose()
    {


        //StartCoroutine(ExecuteAfterTime(10));
        //StartCoroutine(ExecuteAfterTime(3));

        int randomInt = Random.Range(1, 9);


        if (Closed >= 0)
        {
            int tmp = 0;
            Debug.Log(randomInt);
            StartCoroutine(ExecuteAfterTime(randomInt));      
        }
        

    }
}
