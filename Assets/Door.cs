using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

//public class Door : MonoBehaviour
//{
//    // _doorStatus - false = Door is closed
//    // _doorStatus - true = Door is open
//    bool _doorStatus = false;
//    Animator _anim;
//    public UnityEvent onClosed, onOpen;

//    void Start()
//    {
//        _anim = GetComponent<Animator>();
//        _doorStatus = false;
//    }

//    public void useDoor()
//    {
//        if (_doorStatus)
//        {
//            _anim.SetTrigger("DoorOpening");
//            onClosed.Invoke();
//        }
//        else
//        {
//            _anim.SetTrigger("DoorClosing");
//            onOpen.Invoke();
//        }
//        _doorStatus = !_doorStatus;
//    }

//}

public class Door : MonoBehaviour
{
    public Animator animator;
    public bool isOpen = false;

    public void Interact()
    {
        isOpen = !isOpen;                 // переключаем состояние
        animator.SetBool("IsOpen", isOpen);
    }
}
