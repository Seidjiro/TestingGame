using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Album : MonoBehaviour
{
    [SerializeField] private GameObject uiMainTerminal;
    [SerializeField] private GameObject uiPlayerController;
    [SerializeField] private GameObject uiMenuPause;
    [SerializeField] private GameObject uiAlbum;

    /// <summary>
    /// ����� ��������� ������ 
    /// </summary>
    public void ActivePanelAlbum()
    {
        uiPlayerController.SetActive(false);
        uiMenuPause.SetActive(false);
        uiMainTerminal.SetActive(false);
        uiAlbum.SetActive(true);
    }

    /// <summary>
    /// ������ �����
    /// </summary>
    public void ButtonBack()
    {
        uiAlbum.SetActive(false);
        uiMenuPause.SetActive(true);
        uiMainTerminal.SetActive(true);
    }
}
