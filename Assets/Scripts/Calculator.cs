using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using UnityEngine.Serialization;

public class Calculator : MonoBehaviour
{
    [SerializeField] private TMP_Text display;
    [SerializeField] private string calc;
    [SerializeField] private string x;
    [SerializeField] private Button button1;

    private void Awake() => button1.onClick.AddListener(OnClickButton);

    private void OnClickButton() => display.text += calc;
    
    public void OnClickEquals()
    {
        DataTable dt = new DataTable();
        x = (dt.Compute(display.text, "")).ToString();
        display.text = x;
    }
    
    public void OnClickC() => display.text = "";
}
