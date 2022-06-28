using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    private bool dead;

    private void Start()
    {
        life = hearts.Length;  //Put total heart to life variable
    }

    void Update()
    {

    }

    public void TakeDamge(int d)  //Decrease life value and check dead if life value < 1
    {
        life -= d;
        Destroy(hearts[life].gameObject);
        if(life < 1)
        {
            dead = true;
        }
    }



}
