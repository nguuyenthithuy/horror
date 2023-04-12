using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    public GameObject textint, light;
    public bool toggle, intractable;
    public Renderer lightBuld;
    public Material onlight, offlight;
    public AudioSource lightSwitchSound;
    public Animator switchAnim;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            textint.SetActive(true);
            intractable = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            textint.SetActive(false) ;
            intractable = false; ;
        }
    }
    private void Update()
    {
        if(intractable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;
                switchAnim.ResetTrigger("press");
                switchAnim.SetTrigger("press");
            }
        }
        if(toggle == true)
        {
            light.SetActive(true);
            lightBuld.material = onlight;
        }
        if (toggle == false)
        {
            light.SetActive(false);
            lightBuld.material = offlight;
        }
    }
}
