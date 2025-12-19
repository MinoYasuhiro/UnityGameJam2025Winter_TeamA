using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneidou : MonoBehaviour
{

    [SerializeField] private string _loadScene;
    public int _delay; //遅延させたい秒数


    void Start()
    {
        TimeLag();
    }
    public void TimeLag()
    {
        Invoke("SceneChange", _delay);
    }

    public void SceneChange()
    {
        SceneManager.LoadScene(_loadScene);
    }
}