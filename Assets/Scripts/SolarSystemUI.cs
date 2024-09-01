using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SolarSystemUI : MonoBehaviour
{
    public List<Sprite> sprites;

    int index = 0;

    [SerializeField] Image PlanetImage;
    [SerializeField] TextMeshProUGUI PlanetText;
    [SerializeField] GameObject cameraObj;
    // Start is called before the first frame update
    void Start()
    {
        PlanetImage.sprite = sprites[index];
    }

    // Update is called once per frame
    void Update()
    {
        
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

        cameraObj.transform.position = planetToWatch.transform.position + new Vector3(0,10,0);
    
    }
}
