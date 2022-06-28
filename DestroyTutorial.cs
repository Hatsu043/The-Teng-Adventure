using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTutorial : MonoBehaviour
{
    public GameObject Tutorial_jump;
    public GameObject Tutorial_pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Destroy(Tutorial_jump);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(Tutorial_pause);
        }
    }
}
