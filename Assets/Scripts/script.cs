using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    [SerializeField] private string[] letters;


    // Start is called before the first frame update
    void Start()
    {
        Ej1();
        Ej2();
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

    }






}
