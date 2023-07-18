
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerColorizer : MonoBehaviour
{
    private int _curentColorIndex;

    public void Colorize(List<TowerElement> towerElements, TowerTemplate towerTemplate)
    {
       /* foreach (TowerElement element in towerElements)
        {
            element.SetColor(GetElementColor(towerTemplate));
        }*/
    }

    /*private Color GetElementColor(TowerTemplate towerTemplate)
    {
        Color nextColor = towerTemplate.Colors[_curentColorIndex];
        _curentColorIndex++;

        if (_curentColorIndex >= towerTemplate.Colors.Length)
        {
            _curentColorIndex = 0;
        }

        return nextColor;
    }*/
}