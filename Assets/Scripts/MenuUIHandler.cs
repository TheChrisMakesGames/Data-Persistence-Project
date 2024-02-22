using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.IO;
#if UNITY_ENGINE
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public string Username;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew() 
    {
        SceneManager.LoadScene(1);
    }

    public void Exit() 
    {
        MainManager.Instance.SaveUsername();
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
    }

    public void BackToMenu() 
    {
        SceneManager.LoadScene(0);
    }
}
