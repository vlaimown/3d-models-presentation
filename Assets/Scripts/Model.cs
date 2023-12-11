using UnityEngine;
using TMPro;

public class Model : MonoBehaviour
{
    [SerializeField] private TMP_Text generalModelNameText; 
    [SerializeField] private TMP_Text authorModelNameText;
    private string modelName = "";

    [SerializeField] private Canvas canvas;
    private void Start()
    {
        modelName = gameObject.name;
        generalModelNameText.text = modelName;
        authorModelNameText.text = modelName;
    }

    public void SwitchActiveAuthorInfo()
    {
        canvas.gameObject.SetActive(!canvas.gameObject.activeSelf);
        generalModelNameText.gameObject.SetActive(!generalModelNameText.gameObject.activeSelf);
    }
}
