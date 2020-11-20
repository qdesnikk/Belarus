using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Camera))]

public class CheckRegion : MonoBehaviour
{
    [SerializeField] private Region _map;

    private Camera _camera;
    private Region _chekedRegion;
    private float _mapOrthoSize;
    private float _regionOrthoSize;
    private float _focusDuration;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
        _mapOrthoSize = 5f;
        _regionOrthoSize = 3f;
        _focusDuration = 1f;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit)
            {
                if (hit.collider.TryGetComponent(out Region region))
                {
                    if(_chekedRegion != null)
                        _chekedRegion.Uncheck();

                    FocusOn(region, _regionOrthoSize);
                    region.Check();

                    _chekedRegion = region;
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (_chekedRegion != null)
            {
                _chekedRegion.Uncheck();
            }

            FocusOn(_map, _mapOrthoSize);
        }
    }

    private void FocusOn(Region region, float orthoSize)
    {
        _camera.transform.DOMove(region.transform.position + new Vector3(0, 0, _camera.transform.position.z), _focusDuration);
        _camera.DOOrthoSize(orthoSize, _focusDuration);
    }
}
