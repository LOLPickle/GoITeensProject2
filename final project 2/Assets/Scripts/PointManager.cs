using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public static PointManager main;

    public Transform startPoint;
    public Transform[] path;

    private void Awake()
    {
        main = this;
    }
}
