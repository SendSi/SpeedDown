using UnityEngine;
#region << 脚 本 注 释 >>
//作  用:    AniBG
//作  者:    曾思信
//创建时间:  2022/
#endregion


public class AniBG : MonoBehaviour
{
    Material material;
    public Vector2 speed;
    Vector2 movement = Vector2.one;
    private void Start()
    {
        material = this.GetComponent<Renderer>().material;
    }

    private void Update()
    {
        movement += Time.deltaTime * speed;
        material.mainTextureOffset = movement;
    }
}

