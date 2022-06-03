using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class SettingUi : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;
    public TMP_Dropdown qualityDropdown;
    
    // Start is called before the first frame update
    void Start()
    {
        resolutionDropdown.ClearOptions();
        
        resolutionDropdown.AddOptions(
            Screen.resolutions.Select(res => $"{res.width} X {res.height}").ToList()
        );
        resolutionDropdown.onValueChanged.AddListener(UserResolutionSelected);
        
        // Quality Setting
        qualityDropdown.ClearOptions();
        qualityDropdown.AddOptions(
            QualitySettings.names.ToList()
            );
        qualityDropdown.onValueChanged.AddListener(UserQualitySelected);
    }

    private void UserResolutionSelected(int index)
    {
        var resolution = Screen.resolutions[index];
        Screen.SetResolution(resolution.width, resolution.height, true);
    }

    private void UserQualitySelected(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
}
