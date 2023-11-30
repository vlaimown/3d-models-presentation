using Cinemachine;
using UnityEngine;

public class PresentationController : MonoBehaviour
{
    private CinemachineVirtualCamera modelCamera;

    [SerializeField] private int camPriorityHigh;
    [SerializeField] private int camPriorityStandart;

    void Update()
    {
        if (Input.GetButtonDown(GlobalStringVars.CLICK))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                modelCamera = hit.collider.gameObject.GetComponentInChildren<CinemachineVirtualCamera>();
                modelCamera.Priority = camPriorityHigh;
            }
        }
    }

    public void GeneralView()
    {
        modelCamera.Priority = camPriorityStandart;
    }
}
