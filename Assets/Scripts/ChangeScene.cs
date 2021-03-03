using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public string changeScene;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sceneChange()
    {
        SceneManager.LoadScene(changeScene);
    }
}
