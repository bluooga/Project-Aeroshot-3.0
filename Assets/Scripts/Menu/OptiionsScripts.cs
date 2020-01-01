using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptiionsScripts : MonoBehaviour
{

    public TMPro.TMP_Dropdown ResolutionDropDown;

    Resolution[] resolutions;

    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;

        ResolutionDropDown.ClearOptions();

        List<string> options = new List<string>();

        int currentResIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " X " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResIndex = i;
            }
        }

        ResolutionDropDown.AddOptions(options);
        ResolutionDropDown.value = currentResIndex;
        ResolutionDropDown.RefreshShownValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setResolution(int ResolutionIndex)
    {
        Resolution res = resolutions[ResolutionIndex];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }

    public void SetQuality(int QualityLevel)
    {
        QualitySettings.SetQualityLevel(QualityLevel);
    }

    public void setFullScreen(bool isfullScreen)
    {
        Screen.fullScreen = isfullScreen;
    }

}
