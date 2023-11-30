using UnityEngine;
using TMPro;

public class Model : MonoBehaviour
{
    [SerializeField] private TMP_Text modelNameText;
    private string modelName = "";
    void Start()
    {
        modelName = gameObject.name;
        modelNameText.text = modelName;
    }
    void Update()
    {
        
    }
}
