using UnityEngine;

[CreateAssetMenu(menuName = "Custom/NewTowerTemplate")]
public class TowerTemplate : ScriptableObject
{
    [SerializeField] private TowerElement _towerElement;
    [SerializeField] private float _additionalAngle;
    [SerializeField] private TowerPatten[] _towerPattern;
    
    public TowerElement TowerElement => _towerElement;
    public float AdditionalAngle => _additionalAngle;
    public TowerPatten[] TowerPattern => _towerPattern;
  
}