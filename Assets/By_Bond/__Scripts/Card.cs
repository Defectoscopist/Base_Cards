using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [Header("Set Dynamically")]
    public string suit; // масть (C, D, H или S)
    public int rank; // Достоинство карты
    public Color color = Color.black; // Цвет значков
    public string colS = "Black"; // или "Red" - цвет карты,
    public List<GameObject> decoGOs = new List<GameObject>(); // для хранения всех Decorator
    public List<GameObject> pipGOs = new List<GameObject>(); // для хранения всех Pip

    public GameObject back; // рубашка
    public CardDefinition def; // Извлекается из DeckXML.xml

    // переключение режима отображения
    public bool faceUp
    {
        get { return (!back.activeSelf); }
        set { back.SetActive(!value); }
    }
}

[System.Serializable]
public class Decorator
{ // Хранит информацию из DeckXML о каждом значке карты
    public string type; // достоинство карты
    public Vector3 loc; // положение спрайта на карте
    public bool flip = false; // переворот карты
    public float scale = 1f; // Масштаб спрайта
}

[System.Serializable]
public class CardDefinition
{ // Информация о достоинстве карты
    public string face; // Спрайт лицевой стороны карты
    public int rank; // достоинство карты
    public List<Decorator> pips = new List<Decorator>(); // значки
}