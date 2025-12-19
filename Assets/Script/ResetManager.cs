using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetManager : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private Rigidbody playerRb;

    [Header("Player2")]
    [SerializeField] private Rigidbody player2Rb;

    [Header("Cubes")]
    [SerializeField] private Rigidbody[] cubeRbs;

    private Vector3 player2StartPos;
    private Vector3 playerStartPos;
    private Vector3[] cubeStartPos;

    // Start is called before the first frame update
    void Start()
    {
        playerStartPos = playerRb.position;
        player2StartPos = player2Rb.position;

        cubeStartPos = new Vector3[cubeRbs.Length];
        for(int i=0;i<cubeRbs.Length;i++)
        {
            cubeStartPos[i] = cubeRbs[i].position;
        }
    }

    public void ResetAll()
    {
        playerRb.velocity = Vector3.zero;
        playerRb.angularVelocity = Vector3.zero;
        playerRb.position = playerStartPos;

        player2Rb.velocity = Vector3.zero;
        player2Rb.angularVelocity = Vector3.zero;
        player2Rb.position = player2StartPos;

        for (int i=0;i<cubeRbs.Length;i++)
        {
            cubeRbs[i].velocity = Vector3.zero;
            cubeRbs[i].angularVelocity = Vector3.zero;
            cubeRbs[i].position = cubeStartPos[i];
        }
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
