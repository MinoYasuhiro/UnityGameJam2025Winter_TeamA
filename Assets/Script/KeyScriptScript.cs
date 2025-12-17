using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScriptScript : MonoBehaviour
{
    Vector3 Position;
    public Transform target;
    // プレイヤーが触れたときに呼ばれる関数（トリガー判定）
    void OnTriggerEnter(Collider other)
    {
        // 触れたオブジェクトに "Player" タグが付いているかチェック
        if (other.CompareTag("Untagged"))
        {
            Debug.Log("アイテムに触れた！"); // ログを表示
                                    // TODO: アイテム取得処理やエフェクト再生処理などをここに書く


            //this.transform.position = new Vector3(8.4f, -1.98f, -0.04f);
            this.transform.position = target.position;
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
