using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
   public GameObject enemy;
   
    void Start()
    {
        for(float i = 0; i < 10; i++)
        {
            for(float j = 0; j < 10; j++)
            {
                Instantiate(enemy);
                enemy.transform.position = new Vector2(i, j);
            }
        }
    }

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
      Debug.Log("Ouch!");
    }
}
