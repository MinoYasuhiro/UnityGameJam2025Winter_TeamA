using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockDoorScript : MonoBehaviour
{
    Vector3 Position;
    public Transform target;

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
            SceneManager.LoadScene(sceneName); // 指定したシーン名でロード
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
