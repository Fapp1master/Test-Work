using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public Transform SpawnPoint;
    public Transform item;
    public float n;
    private float distance;

    private void Update()
    {
        CalculatingWithDistance();
        SpawnItem();

    }
    private void CalculatingWithDistance()
    {
        distance = Vector2.Distance(transform.position , item.position);
    }
    private void SpawnItem()
    {
       
         if (Input.GetKeyDown(KeyCode.LeftShift))
        { 

            gameObject.GetComponent<Renderer>().material.color = Color.yellow;

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            if (distance > n)
            {
                item.position = SpawnPoint.position;
            }
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }

        
    }

}

