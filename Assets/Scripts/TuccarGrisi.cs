using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseInteraction : MonoBehaviour
{
    public int sceneIndex = 1; // Yüklemek istediðiniz sahnenin indeks numarasý veya ismini yazabilirsiniz.

    private void OnMouseDown()
    {
        // Sahneyi yükle
        SceneManager.LoadScene(sceneIndex);
    }
}

