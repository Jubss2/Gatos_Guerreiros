using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ataque : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        Controllerat.AnimFruta += AnimationFru;
    }

    private void OnDisable()
    {
        Controllerat.AnimFruta -= AnimationFru;
    }
    // Update is called once per frame
     public void AnimationFru()
      {
         _animator.SetTrigger("ataque");
         _animator.Play("ataque");
     }
}
