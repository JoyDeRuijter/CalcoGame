using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    //Switches the current scene with the scene that matches the injected sceneName
    public void SwitchScene(string _sceneName) => SceneManager.LoadScene(_sceneName);
}
