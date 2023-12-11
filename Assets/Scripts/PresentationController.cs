using Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class PresentationController : MonoBehaviour
{
    private CinemachineVirtualCamera modelCamera;

    [SerializeField] private int camPriorityHigh;
    [SerializeField] private int camPriorityStandart;

    [SerializeField] private Button generalViewBtn;

    private Model selectedModel;

    private void Start()
    {
        generalViewBtn.gameObject.SetActive(false);
    }

    private void Update()
    {
        SwitchViewToModel();
    }

    private void SwitchViewToModel()
    {
        if (Input.GetButtonDown(GlobalStringVars.CLICK) && !generalViewBtn.gameObject.activeSelf)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                selectedModel = hit.collider.GetComponent<Model>();

                modelCamera = hit.collider.gameObject.GetComponentInChildren<CinemachineVirtualCamera>();
                modelCamera.Priority = camPriorityHigh;

                generalViewBtn.gameObject.SetActive(true);

                selectedModel.SwitchActiveAuthorInfo();

                Debug.Log(selectedModel);
            }
        }
    }

    public void GeneralView()
    {
        selectedModel.SwitchActiveAuthorInfo();
        modelCamera.Priority = camPriorityStandart;
        generalViewBtn.gameObject.SetActive(false);
    }
}
