using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Untagged"))
        {
            Debug.Log("ロック解除！"); // ログを表示
                                    // TODO: アイテム取得処理やエフェクト再生処理などをここに書く


            //アイテムを消す
            Destroy(this.gameObject);
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
