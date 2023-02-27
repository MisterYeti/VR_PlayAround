using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnValidate : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _spawnPoint;
    [SerializeField] float _fireSpeed = 20;

    private void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    private void FireBullet(ActivateEventArgs arg)
    {
        GameObject spawnedBullet = Instantiate(_bullet);
        spawnedBullet.transform.position = _spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = _spawnPoint.forward * _fireSpeed;
        Destroy(spawnedBullet, 5.0f);
    }
}
