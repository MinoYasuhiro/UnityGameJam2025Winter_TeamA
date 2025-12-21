using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPushPlayerScript
{
    Vector3 MoveDirection { get; }

    Transform transform { get; }
}
