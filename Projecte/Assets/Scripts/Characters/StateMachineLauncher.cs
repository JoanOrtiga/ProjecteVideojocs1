using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineLauncher : MonoBehaviour {

    void Update()
    {
        CharacterState[] states = GetComponents<CharacterState>();
        foreach (CharacterState state in states)
        {
            state.InitState();
            if (state.IsDefaultState)
                state.enabled = true;
        }

        this.enabled = false;
    }
}
