using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{
    public void Start()
    {
        Debug.Log("Starting");
    }
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("next scene");
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
