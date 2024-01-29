using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class script : MonoBehaviour
{

    [SerializeField] private string[] letters;

    [SerializeField] private string palabra;

    private string word;


    // Start is called before the first frame update
    void Start()
    {
        Ej1();
        Ej2();
        Ej3();
        Ej4();
        Ej5();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void Ej1()
    {
        int sum = 0;

        for (int i = 0; i <= 100; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
    }

    private void Ej2()
    {
        int count = 0;

        foreach (string letter in letters)
        {
            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
            {
                count++;
            }
        }
        Debug.Log(count);



    }

    private void Ej3()
    {
        for (int i = 10;i >= 1; i--)
        {
            //Debug.Log(i);
            Debug.Log($"{i} green bottles\r\nHanging on the wall\r\n{i} green bottles\r\nHanging on the wall\r\nAnd if one green bottle\r\nShould accidentally fall\r\nThere’ll be {i-1} green bottles\r\nHanging on the wall ");
        }

    }

    private void Ej4()
    {
        int sum = 0;
        int rnumber = 0;

        while (rnumber != 5)
        {
            rnumber = Random.Range(0, 10);
            sum += rnumber;
        }

        if(sum > 100)
        {
            Debug.Log("The sum of the numbers is greater than 100" + $". Number: {sum}");

        }
        else
        {
            Debug.Log("The sum of the numbers is less than 100" + $". Number: {sum}");

        }

        //Debug.Log(sum);



    }
    
    private void Ej5()
    {
        
        for (int i = 0; i < palabra.Length; i++)
        {
            //string letra = palabra[i];
            if(palabra[i] != 'a')
            {
                //Debug.Log(palabra[i]);
                word += $"{palabra[i]}";
            }
            else
            {
                Debug.Log(word);
                return;
            }



            
            
        }
    }





}
