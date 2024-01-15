using System;
using UnityEngine;

public class LineBase : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;
    private LineRenderer lr;

    private void Start()
    {
        lr = this.GetComponent<LineRenderer>();
    }

    private void Update()
    {
        lr.SetPosition(0,startPos.position);
        lr.SetPosition(1,endPos.position);
    }
}
