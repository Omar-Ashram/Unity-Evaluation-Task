using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;

public class SolarSystemUI : MonoBehaviour
{
    public List<Sprite> sprites;

    int index = 0;

    [SerializeField] Image PlanetImage;
    [SerializeField] TextMeshProUGUI PlanetText;
    [Space]
    [SerializeField] CinemachineVirtualCamera PlanetCam;
    [SerializeField] CinemachineVirtualCamera TopCam;

    public  CinemachineTransposer vcamOffSet;

    private void Awake()
    {
        if (vcamOffSet == null)
            vcamOffSet = PlanetCam.GetCinemachineComponent<CinemachineTransposer>();
        else
            Debug.Log("null");
    }
    // Start is called before the first frame update
    void Start()
    {
        PlanetImage.sprite = sprites[index];
    }

    public void increaseIndex() {
        if(index <sprites.Count - 1) 
            index++; 
        PlanetImage.sprite = sprites[index];
        PlanetText.text = sprites[index].name;
    }
    public void decreaseIndex() {
        if(index > 0) 
            index--; 
        PlanetImage.sprite = sprites[index];
        PlanetText.text = sprites[index].name;
    }

    public void WatchPlanet() 
    {
        GameObject planetToWatch = GameObject.Find(sprites[index].name);
        PlanetCam.Follow = planetToWatch.transform;
        PlanetCam.LookAt = planetToWatch.transform;

        Vector3 FollowOffset = planetToWatch.GetComponent<PlanetCloseCam>().FollowOffset;
        vcamOffSet.m_FollowOffset = FollowOffset;
        TopCam.enabled = false;
        PlanetCam.enabled = true;
    }

    public void WatchTop() 
    {
        TopCam.enabled = true;
        PlanetCam.enabled = false;

    }
}
