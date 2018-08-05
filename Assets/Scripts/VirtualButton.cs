using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Events;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{


    [SerializeField]
    private UnityEvent onClicked;

    [SerializeField]
    public UnityEvent onReleased;


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        onClicked.Invoke();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        onReleased.Invoke();
    }

    // Use this for initialization
    void Start()
    {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
