using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    int last = 0;
    int[] massive;
    void Start()
    {
        massive = new int[10];
        for (int i = 0; i < 10; ++i)
        {
            massive[i] = 0;
        }
    }

    //функция добавления предмета
    public void Add(int id)
    {
        massive[last] = id;
        last++;
    }
    private void Update()
    {
        //Debug.Log(massive[0]);
    }
}
