using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    // make sure sprite is clickable / has collider 
    [SerializeField] string sceneName = "TextIntro";

    public void LoadNextScene() {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadScene(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
