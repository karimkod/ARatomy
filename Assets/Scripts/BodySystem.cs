using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BodySystem
{

    [SerializeField]
    private GameObject systemModel;

    [TextArea]
    [SerializeField]
    private string title;

    [TextArea]
    [SerializeField]
    private string description;

    public GameObject SystemModel
    {
        get
        {
            return systemModel;
        }

        set
        {
            systemModel = value;
        }
    }

    public string Title
    {
        get
        {
            return title;
        }

        set
        {
            title = value;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }

        set
        {
            description = value;
        }
    }
}
