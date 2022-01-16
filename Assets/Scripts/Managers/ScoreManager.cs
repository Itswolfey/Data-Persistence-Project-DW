using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public string playerName;
    public string highScore;
    public static GameObject Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
