using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 3f;

    public float startingTime = 3f;
    float currentTime = 0f;

    private void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {

        currentTime -= 1 * Time.deltaTime;
        if(currentTime <= 0)
        {
            LoadNextLevel();
        }

    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
