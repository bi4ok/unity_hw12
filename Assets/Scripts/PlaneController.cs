using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private GameObject plane;
    private Animator planeAnimation;

    private void Awake()
    {
        planeAnimation = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        planeAnimation.SetTrigger("FallDown");
    }

    private void PlaneOffAfterDrop()
    {
        plane.SetActive(false);
    }

}
