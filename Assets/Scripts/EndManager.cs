using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    private void OnEnable()
    {
        Animator child = this.GetComponentInChildren<Animator>();
        child.SetTrigger("DropMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Retry()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }


}
