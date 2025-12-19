using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockDoorScript : MonoBehaviour
{
    Vector3 Position;
    public Transform target;
    int PlayerCount = 0;

    [SerializeField] private string sceneName;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Untagged"))
        {
            this.transform.position = target.position;
            Vector3 currentPosition = transform.position;
            transform.position = new Vector3(currentPosition.x, currentPosition.y, 0.29f);
        }

        if (other.CompareTag("Player"))
        {
            PlayerCount += 1;
        }
       

        if (PlayerCount == 2)
        {
            SceneManager.LoadScene(sceneName); // 指定したシーン名でロード
        }
        if(PlayerCount <= 0)
        {
            PlayerCount = 0;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerCount--;

            if (PlayerCount < 0)
            {
                PlayerCount = 0;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
