using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GateSwitchScene : MonoBehaviour
{
    public int StageNum;
    private void OnTriggerEnter(Collider other)  //Load scene
    {
        SceneManager.LoadScene(StageNum);
    }
}
