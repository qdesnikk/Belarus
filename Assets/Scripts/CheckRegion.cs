using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]

public class CheckRegion : MonoBehaviour
{
    private Camera _camera;

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
                    FocusOn(region);
                    region.OnCheck();
                }
            }
        }
    }

    private void FocusOn(Region region)
    {
        _camera.transform.position = region.transform.position + new Vector3(0, 0, _camera.transform.position.z);
        _camera.orthographicSize = 3;
    }
}
