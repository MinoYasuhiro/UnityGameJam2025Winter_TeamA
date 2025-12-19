using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleManagerScript : MonoBehaviour
{
    [SerializeField] RedCircle red;
    [SerializeField] BlueCircle blue;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(true)
        {
            //赤：消灯
            //青：点灯
            red.SetOff();
            blue.SetOn();
            yield return new WaitForSeconds(5f);

            //赤：消灯
            //青：点滅
            float t = 0f;
            while(t<3f)
            {
                blue.SetBlink(!blue.GetComponent<MeshRenderer>().enabled);
                yield return new WaitForSeconds(0.2f);
                t += 0.2f;
            }

            //赤：点灯
            //青：消灯
            red.SetOn();
            blue.SetOff();
            yield return new WaitForSeconds(3f);

            //赤：消灯
            //青：消灯
            //red.SetOff();
            //blue.SetOff();
            //yield return new WaitForSeconds(3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
