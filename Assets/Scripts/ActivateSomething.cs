using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ActivateSomething : MonoBehaviour
{
    [SerializeField] private GameObject _targetToActivate;
    private Animator _currentAnimation;

    private void Awake()
    {
        _currentAnimation = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _currentAnimation.SetBool("Pressed", true);
        _targetToActivate.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        _currentAnimation.SetBool("Pressed", false);
    }

}
