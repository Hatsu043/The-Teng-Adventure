using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    int checkDelete = 0;
    bool checkExit = false;
    private void OnTriggerExit(Collider other)  //Decrease life value of player when hit player
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
            if (GameObject.Find("Heart5") != null && checkExit == true)
            {
                Destroy(GameObject.Find("Heart5"));
                checkExit = false;
                checkDelete += 1;
            }
            else
            {
                if (GameObject.Find("Heart4") != null && checkExit == true)
                {
                    Destroy(GameObject.Find("Heart4"));
                    checkExit = false;
                    checkDelete += 1;
                }
                else
                {
                    if (GameObject.Find("Heart3") != null && checkExit == true)
                    {
                        Destroy(GameObject.Find("Heart3"));
                        checkExit = false;
                        checkDelete += 1;
                    }
                    else
                    {
                        if (GameObject.Find("Heart2") != null && checkExit == true)
                        {
                            Destroy(GameObject.Find("Heart2"));
                            checkExit = false;
                            checkDelete += 1;
                        }
                        else
                        {
                            if (GameObject.Find("Heart1") != null && checkExit == true)
                            {
                                Destroy(GameObject.Find("Heart1"));
                                checkExit = false;
                                checkDelete += 1;
                            }
                            else
                            {
                                if (checkDelete == 5)
                                {
                                    SceneManager.LoadScene("GameOver");
                                }
                            }
                        }
                    }
                }
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            checkExit = true;
        }
    }

}
