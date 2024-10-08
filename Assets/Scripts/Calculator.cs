using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class Calculator : MonoBehaviour
{
    [SerializeField] private TMP_Text Text1;
    [SerializeField] private string calc1;
    [SerializeField] private string x1;
    [SerializeField] private Button button1;

    private void Awake() => button1.onClick.AddListener(OnClickButton);

    private void OnClickButton() => Text1.text += calc1;
    
    
    public void OnClickEquals()
    {
        DataTable dt = new DataTable();
        x1 = (dt.Compute(Text1.text, "")).ToString();
        Text1.text = x1;
    }

    public void OnClickC()
    {
        Text1.text = "";
    }
}
