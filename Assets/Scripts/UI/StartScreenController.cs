using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenController : UIController
{
    [SerializeField] private string sceneName;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SwitchScene(sceneName);
    }
}
