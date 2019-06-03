using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // New instance variable
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    // Current state
    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();

    }

    // Update is called once per frame
    void Update()
    {
        ManageState();

    }

    private void ManageState()
    {
        var NextState = state.GetNextState();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = NextState[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = NextState[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = NextState[2];
        }

        textComponent.text = state.GetStateStory();
    }
}
