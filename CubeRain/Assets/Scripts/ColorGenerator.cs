using System.Collections.Generic;
using UnityEngine;

public class ColorGenerator : MonoBehaviour
{
  /*  private List<Color> _customHDRColors = new()
   {
         new Color(0,0,255),    // customBlue
         new Color(0,243,255),  // customBlue2
         new Color(255,0,255),  // customPink
         new Color(255,0,99),   // customPink2
         new Color(255,0,0),    // customRad
         new Color(255,0,6),    // customRad2
         new Color(255,195,0),  // customYellow
         new Color(22,255,0),   // customGreen
         new Color(222,236,236) // customWhite
   };*/

    [SerializeField] private List<Material> _materials;

    public Color GetRandomCustomHDRColor()
    {
        return _materials [Random.Range(0, _materials.Count)].color;
    }
}