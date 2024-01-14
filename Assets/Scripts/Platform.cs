using System;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private Vector3 moveMent;
    public float speed;
    private GameObject topLine;
    private void Update()
    {
        topLine = GameObject.Find("topLine");
        MovePlatform();
        moveMent.y = speed;
    }

    private void MovePlatform()
    {
        transform.position += moveMent * Time.deltaTime;
        if (transform.position.y >= topLine.transform.position.y)
        {
            Destroy(this.gameObject);
        }
       
    }
}
