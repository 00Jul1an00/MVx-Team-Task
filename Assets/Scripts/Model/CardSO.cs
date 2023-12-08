using UnityEngine;

[CreateAssetMenu(fileName = "CardSO", menuName = "For GD/Card")]
public class CardSO : ScriptableObject
{
    [field: SerializeField] public Color Color { get; private set; }
    [field: SerializeField] public string Name { get; private set; }
}
