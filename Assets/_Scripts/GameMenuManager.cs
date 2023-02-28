using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    [SerializeField] Transform _head;
    [SerializeField] float _distance = 2.0f;
    [SerializeField] GameObject _menu;
    [SerializeField] InputActionProperty _showUIButton;


    private void Update()
    {
        if (_showUIButton.action.WasPressedThisFrame())
        {
            _menu.SetActive(!_menu.activeSelf);

            _menu.transform.position = _head.position + new Vector3(_head.forward.x, 0, _head.forward.z).normalized * _distance;
        }

        _menu.transform.LookAt(new Vector3(_head.position.x, _head.transform.position.y, _head.transform.position.z));
        _menu.transform.forward *= -1;
    }

}
