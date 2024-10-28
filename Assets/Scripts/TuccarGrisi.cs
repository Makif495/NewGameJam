using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseInteraction : MonoBehaviour
{
    public int sceneIndex = 1; // Y�klemek istedi�iniz sahnenin indeks numaras� veya ismini yazabilirsiniz.

    private void OnMouseDown()
    {
        // Sahneyi y�kle
        SceneManager.LoadScene(sceneIndex);
    }
}

