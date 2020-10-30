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

    private bool _isCheckedAnyRegion;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
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
                    if(_chekedRegion != region)
                    {
                        if(_chekedRegion != null)
                            _chekedRegion.Uncheck();

                        FocusOn(region, 3f, 1f);
                        region.Check();

                        _chekedRegion = region;
                        _isCheckedAnyRegion = true;
                    }
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (_chekedRegion != null)
                _chekedRegion.Uncheck();

            FocusOn(_map, 5f, 1f);
            _isCheckedAnyRegion = false;
        }
    }

    private void FocusOn(Region region, float orthoSize, float duration)
    {
        _camera.transform.DOMove(region.transform.position + new Vector3(0, 0, _camera.transform.position.z), duration);
        _camera.DOOrthoSize(orthoSize, duration);
    }
}
