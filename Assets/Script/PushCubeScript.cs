using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PushCubeScript : MonoBehaviour
{
    public int requiredPlayers = 2;
    public float moveSpeed = 2f;
    public float supportRange = 1.0f;

    private List<IPushPlayerScript> touchingPlayers = new List<IPushPlayerScript>();
    private IPushPlayerScript[] allPlayers;
    private Rigidbody rb;
    private Vector3 moveDir;
    private bool shouldMove;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInParent<Rigidbody>();
        allPlayers = FindObjectsOfType<MonoBehaviour>().OfType<IPushPlayerScript>().ToArray();
    }

    void OnTriggerEnter(Collider other)
    {
        IPushPlayerScript player = other.GetComponent<IPushPlayerScript>();
        if(player!=null&&!touchingPlayers.Contains(player))
        {
            touchingPlayers.Add(player);
        }
    }

    void OnTriggerExit(Collider other)
    {
        IPushPlayerScript player = other.GetComponent<IPushPlayerScript>();
        if(player!=null)
        {
            touchingPlayers.Remove(player);
        }
    }

    // Update is called once per frame
    void Update()
    {
        shouldMove = false;
        foreach(IPushPlayerScript frontPlayer in touchingPlayers)
        {
            Vector3 frontMoveDir = frontPlayer.MoveDirection;

            if (frontMoveDir == Vector3.zero) continue;

            int pushCount = 1;

            foreach (IPushPlayerScript otherPlayer in allPlayers)
            {
                if (otherPlayer == frontPlayer) continue;

                if (otherPlayer.MoveDirection == Vector3.zero) continue;

                float distance = Vector3.Distance(frontPlayer.transform.position, otherPlayer.transform.position);

                if (distance > supportRange) continue;

                float dot = Vector3.Dot(frontMoveDir.normalized,otherPlayer.MoveDirection.normalized);

                if(dot>0.7f)
                {
                    pushCount++;
                }
            }
            if(pushCount>=requiredPlayers)
            {
                moveDir = new Vector3(Mathf.Sign(frontMoveDir.x), 0f, 0f);
                shouldMove = true;
                break;
            }
        }
    }

    void FixedUpdate()
    {
        if (!shouldMove) return;
        if (rb == null) return;

        Vector3 dir = new Vector3(Mathf.Sign(moveDir.x), 0f, 0f);
        Vector3 step = dir * moveSpeed * Time.fixedDeltaTime;

        if(rb.SweepTest(dir,out RaycastHit hit,step.magnitude,QueryTriggerInteraction.Ignore))
        {
            return;
        }

        rb.MovePosition(rb.position + step);
    }
}
