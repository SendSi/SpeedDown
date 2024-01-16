using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BaseGenerate : MonoBehaviour
{
    public List<GameObject> baseTrans = new List<GameObject>();
    private Vector3 startPos;
    public float offsetTime=5;

    private void Start()
    {
        startPos = this.gameObject.transform.position;
    }

    private float tmpIndex = 0;
    private void Update()
    {
        tmpIndex = tmpIndex + Time.deltaTime;
        if (tmpIndex>=offsetTime)
        {
            tmpIndex = 0;
            
            int inndex = Random.Range(0, baseTrans.Count);
            var go = GameObject.Instantiate(baseTrans[inndex], startPos, Quaternion.identity);
            go.transform.SetParent(this.transform);
            go.transform.position =new Vector3( Random.Range(-2.5f, 2.5f),startPos.y,startPos.z);
        }

    }
}