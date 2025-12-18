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
            //赤色の円が消えている時間
            state = LightState.Off;
            mesh.enabled = false;
            yield return new WaitForSeconds(8f);

            //赤色の円が現れている時間
            state = LightState.On;
            mesh.enabled = true;
            yield return new WaitForSeconds(3f);
        }
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
