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
    string[] dayOfWeek = { "mon", "tue", "wed", "thu", "fri", "sat", "sun" };

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(dayOfWeek[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
