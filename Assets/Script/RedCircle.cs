using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCircle : MonoBehaviour
{
    public LightState state { get; private set; }
    MeshRenderer mesh;
    // Start is called before the first frame update
    void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    public void SetOn()
    {
        state = LightState.On;
        mesh.enabled = true;
    }

    public void SetOff()
    {
        state = LightState.Off;
        mesh.enabled = false;
    }

    public bool IsDanger()
    {
        return state == LightState.On;
    }
    // Update is called once per frame
    //void Update()
    //{

    //}
}
