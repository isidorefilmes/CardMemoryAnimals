using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainRandomScene : MonoBehaviour {

    public void LoadRandomScene()
    {
        //by using the Random.Range method to load random scenes.
        int index = Random.Range(1, 5);
        SceneManager.LoadScene(index);
        Debug.Log("Scene loaded");
    }

}
