using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float range = 3f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = Camera.main.transform.forward;
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.transform.position, ray, out hit, range))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();

                if (interactable != null)
                {
                    interactable.Interact();
                }
            }
        }
    }
}