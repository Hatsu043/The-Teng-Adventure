using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDetect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)  //Detect player when was hited by players then destroy Bull
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("Head");
            if (GameObject.Find("Bull") != null)
            {
                Destroy(GameObject.Find("Bull"));
            }
        }

    }
}
