using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManipulator : MonoBehaviour
{
    [SerializeField] private const float DEFAULT_GRAVITY = -9.81f;
    [SerializeField] private const float SCENE_GRAVITY = -981f;

    private void OnEnable()
    {
        Physics.gravity = new Vector3 (0, SCENE_GRAVITY, 0);
    }

    private void OnDestroy()
    {
        Physics.gravity = new Vector3 (0, DEFAULT_GRAVITY, 0);
    }

}
