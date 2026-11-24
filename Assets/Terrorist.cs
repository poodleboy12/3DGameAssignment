using UnityEngine;
using UnityEngine.InputSystem;
public class Terrorist : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if (Physics.Raycast(ray, out RaycastHit hit)) {
                Debug.Log("Hit: " + hit.collider.gameObject.name);
                if (hit.collider.gameObject == this.gameObject) {
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
