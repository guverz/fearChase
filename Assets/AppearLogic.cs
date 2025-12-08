using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearLogic : MonoBehaviour
{
    public Inventory inventory;
    public GameObject fuse;
    public GameObject trueFuse;
    public Animator animator;
    public bool isOpen = false;
    public void CheckFuse()
    {
        if (inventory.HaveFuse)
        {
            fuse.SetActive(false);
            trueFuse.SetActive(true);
            isOpen = !isOpen;
            animator.SetBool("IsOpen", isOpen);
        }
    }
}
