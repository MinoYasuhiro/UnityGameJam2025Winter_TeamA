using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCircle : MonoBehaviour
{
    public LightState state = LightState.Blinking;
    MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        StartCoroutine(StateControl());
    }

    IEnumerator StateControl()
    {
        while (true)
        {
            state = LightState.Off;
            mesh.enabled = false;
            yield return new WaitForSeconds(8f);

            state = LightState.On;
            mesh.enabled = true;
            yield return new WaitForSeconds(3f);
        }
    }

    public bool IsDanger()
    {
        return state == LightState.Off;
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}
