using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scene2Manager : MonoBehaviour
{
    public TMP_Text displayUserName;

    public void Awake()
    {
        displayUserName.text = Scene1Manager.scene1.userName;
    }


}
