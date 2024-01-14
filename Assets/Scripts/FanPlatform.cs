using System;
using UnityEngine;

public class FanPlatform : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
          _animator.Play("base3_run");
        }
    }
}
