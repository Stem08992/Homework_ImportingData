using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ViewController : MonoBehaviour
{
    private DataBase _dataBase;
    private int _index = 0;

    public Image background;
    public TextMeshProUGUI title;
    public TextMeshProUGUI str;
    public TextMeshProUGUI stm;
    public TextMeshProUGUI intel;
    
    // Connects to the database, initiates reading from JSON, update visuasl to first index 
    private void Start() {
        _dataBase = GameObject.Find("Database").GetComponent<DataBase>();
        _dataBase.ReadData();
        if (_dataBase.levels.Count != 0) {
           SetVisuals();
        }
    }

    // Moves index up by one, loops if overflows, updates visuals
    public void Next() {
        _index++;
        if (_index >= _dataBase.levels.Count) {
            _index = 0;
        }
        SetVisuals();
    }

    // Move index down by one, loops if overflows, updates visuals 
    public void Prev() {
        _index--;
        if (_index < 0) {
            _index = _dataBase.levels.Count - 1;
        }
        SetVisuals();
    }
    
    // Updates visuals to display the new data 
    private void SetVisuals() {
        background.sprite = _dataBase.levels[_index].Sprite;
        title.text = _dataBase.levels[_index].Title;
        str.text = "STR: " + _dataBase.levels[_index].Str;
        stm.text = "STR: " + _dataBase.levels[_index].Stm;
        intel.text = "INT: " + _dataBase.levels[_index].Int; 
    }
}
