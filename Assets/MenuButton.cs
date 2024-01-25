using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void ToTheSheetScreen()
    {
        SceneManager.LoadScene(1);
    }
}
