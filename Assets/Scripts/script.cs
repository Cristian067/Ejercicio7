using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    [SerializeField] private string[] letters;

    [SerializeField] private string palabra;


    // Start is called before the first frame update
    void Start()
    {
        Ej1();
        Ej2();
        Ej3();
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

    }
    
    private void Ej5()
    {
        for (int i = 0; i < palabra.Length; i++)
        {
            Debug.Log(palabra[i]);
        }
    }





}
