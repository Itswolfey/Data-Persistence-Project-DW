using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scene1Manager : MonoBehaviour
{
    public static Scene1Manager scene1;
    public TMP_InputField inputField;

    public string userName;


    private void Awake()
    {
        if (scene1 == null)
        {
            scene1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayerName()
    {
        userName = inputField.text;
        SceneManager.LoadSceneAsync("main");
    }










}
