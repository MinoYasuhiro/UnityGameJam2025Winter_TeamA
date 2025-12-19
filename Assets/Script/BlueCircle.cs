using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCircle : MonoBehaviour
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

    public void SetBlink(bool visible)
    {
        state = LightState.Blinking;
        mesh.enabled = visible;
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
