using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Lab3");
    }

    public void ComecarNovoJogo()
    {
        int ultimoJogo = 0;
        int numRecord = 0;
        PlayerPrefs.SetInt("Jogadas", ultimoJogo);
        PlayerPrefs.SetInt("Record", numRecord);
        SceneManager.LoadScene("Lab3");
    }

    public void FinishGame()
    {
        SceneManager.LoadScene("Lab3_End");
    }

    public void TelaDeInicio()
    {
        SceneManager.LoadScene("Lab3_TelaComeco");
    }
}
