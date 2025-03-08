using UnityEngine;

public class PanelController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Panel;

    public void ClickButton(bool open)
    {
        Panel.SetActive(open);
    }
}
