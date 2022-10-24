using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private enum Scene
    { 
        main, 
        coffee
    }

    [SerializeField]
    private Scene scene;

    public void OnClickChangeScene()
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void Quit()
    {
        Application.Quit();
    }

}
