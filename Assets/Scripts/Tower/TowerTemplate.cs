using UnityEngine;

[CreateAssetMenu(menuName = "Custom/NewTowerTemplate")]
public class TowerTemplate : ScriptableObject
{
    [SerializeField] private TowerElement _towerElement;
    [SerializeField] private float _additionalAngle;
    [SerializeField] private TowerCreatorPatten[] _towerCreatorPattern;
    
    public TowerElement TowerElement => _towerElement;
    public float AdditionalAngle => _additionalAngle;
    public TowerCreatorPatten[] TowerCreatorPattern => _towerCreatorPattern;
  
}