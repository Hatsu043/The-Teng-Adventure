using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Herb : MonoBehaviour
{
    public Text herbDisplay;
    int herbNumber = 0;

    private void Update()
    {
        herbNumber = int.Parse(herbDisplay.text);
    }
    private void OnTriggerEnter(Collider other)  //Increase herb number when get herb item
    {
        if (other.gameObject.tag == "Player")
        {
            herbNumber += 1;
        }
        Destroy(this.gameObject);
        herbDisplay.text = herbNumber.ToString();
        Debug.Log(herbNumber);

    }
}
