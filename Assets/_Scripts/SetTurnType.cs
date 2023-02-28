using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnType : MonoBehaviour
{
    [SerializeField] ActionBasedContinuousTurnProvider _continuousTurn;
    [SerializeField] ActionBasedSnapTurnProvider _snapTurn;

    public void SetTypeFromIndex(int index)
    {
        if (index == 0)
        {
            _snapTurn.enabled = false;
            _continuousTurn.enabled = true;
        }
        else if (index == 1)
        {
            _snapTurn.enabled = true;
            _continuousTurn.enabled = false;
        }
    }
}
