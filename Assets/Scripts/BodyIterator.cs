using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BodyIterator : MonoBehaviour {

    [SerializeField]
    private BodySystem[] systemsArray;


    [SerializeField]
    private TextMesh title;

    [SerializeField]
    private TextMesh description;

    [SerializeField]
    private int currentIndex = 0;

	// Use this for initialization
	void Start ()
    {
        Move(0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Move(int direction)
    {
        var currentSystem = systemsArray[currentIndex];
        currentSystem.SystemModel.SetActive(false);

        currentIndex += direction;
        if (currentIndex < 0) currentIndex = systemsArray.Length - 1;
        else if (currentIndex >= systemsArray.Length) currentIndex = 0;

        currentSystem = systemsArray[currentIndex];
        currentSystem.SystemModel.SetActive(true);
        title.text = currentSystem.Title;
        description.text = currentSystem.Description;


    }


}
