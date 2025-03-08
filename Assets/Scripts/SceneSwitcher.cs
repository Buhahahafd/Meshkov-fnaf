using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject TestPan;
    public void OpenMenu(int scene)
    {
        SceneManager.LoadScene(scene);
    }

}
