using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<player>().ResetGame();
    }
}
