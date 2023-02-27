using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    [SerializeField] private GameObject _leftTeleportation;
    [SerializeField] private GameObject _rightTeleportation;

    [SerializeField] private InputActionProperty _leftActivate;
    [SerializeField] private InputActionProperty _rightActivate;

    [SerializeField] private InputActionProperty _leftCancel;
    [SerializeField] private InputActionProperty _rightCancel;

    private void Update()
    {
        _leftTeleportation.SetActive(_leftCancel.action.ReadValue<float>() == 0 &&_leftActivate.action.ReadValue<float>() > 0.1f);
        _rightTeleportation.SetActive(_rightCancel.action.ReadValue<float>() == 0 && _rightActivate.action.ReadValue<float>() > 0.1f);
        Debug.Log(_rightActivate.action.ReadValue<float>());
    }


}
