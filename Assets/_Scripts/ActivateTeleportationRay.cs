using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateTeleportationRay : MonoBehaviour
{
    [SerializeField] private GameObject _leftTeleportation;
    [SerializeField] private GameObject _rightTeleportation;

    [SerializeField] private InputActionProperty _leftActivate;
    [SerializeField] private InputActionProperty _rightActivate;

    [SerializeField] private InputActionProperty _leftCancel;
    [SerializeField] private InputActionProperty _rightCancel;

    [SerializeField] private XRRayInteractor _leftRay;
    [SerializeField] private XRRayInteractor _rightRay;

    private void Update()
    {
        bool isLeftRayHovering = _leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber, out bool leftValid);
        bool isRightRayHovering = _rightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber,out bool rightValid);

        _leftTeleportation.SetActive(!isLeftRayHovering && _leftCancel.action.ReadValue<float>() == 0 &&_leftActivate.action.ReadValue<float>() > 0.1f);
        _rightTeleportation.SetActive(!isRightRayHovering && _rightCancel.action.ReadValue<float>() == 0 && _rightActivate.action.ReadValue<float>() > 0.1f);
    }


}
