using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public GameObject centerEyeAnchor;
    private OVRScreenFade _OVRScreenFade;
    // Start is called before the first frame update
    void Start()
    {
        _OVRScreenFade = centerEyeAnchor.GetComponent<OVRScreenFade>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            StartCoroutine("LoadSceneCoroutine");
        }
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            SceneManager.LoadScene("CleanedUp_Bedroom");
        }
    }

    private IEnumerator LoadSceneCoroutine()
    {
        _OVRScreenFade.fadeOnStart = true;
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("Demo Night");
    }
}
