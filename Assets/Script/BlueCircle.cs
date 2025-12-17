using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCircle : MonoBehaviour
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
            state = LightState.On;
            mesh.enabled = true;
            yield return new WaitForSeconds(5f);

            state = LightState.Blinking;
            float t = 0f;
            while(t<3f)
            {
                mesh.enabled = !mesh.enabled;
                yield return new WaitForSeconds(0.2f);
                t += 0.2f;
            }

            state = LightState.Off;
            mesh.enabled = false;
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
