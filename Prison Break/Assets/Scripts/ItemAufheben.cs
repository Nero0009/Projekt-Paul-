using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAufheben : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private LayerMask pickupLayer;

    private Camera cam;

    private void Start() {
        GetReferences();
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.E)) {
            Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, range, pickupLayer)) {
                Debug.Log("Treffer: " + hit.transform.name);
            }

        }
    }

    private void GetReferences() {
        cam = GetComponentInChildren<Camera>();
    }
}
